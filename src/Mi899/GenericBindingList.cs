using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Mi899
{
    internal class GenericBindingList<T> : List<T>, IBindingList
    {
        private readonly GenericComparer<T> _comparer = new GenericComparer<T>();

        public bool AllowEdit => false;

        public bool AllowNew => false;

        public bool AllowRemove => false;

        public bool IsSorted { get; protected set; }

        public ListSortDirection SortDirection { get; protected set; }

        public PropertyDescriptor SortProperty { get; protected set; }

        public bool SupportsChangeNotification => false;

        public bool SupportsSearching => false;

        public bool SupportsSorting => true;

        public event ListChangedEventHandler ListChanged;

        public GenericBindingList(IEnumerable<T> source)
        {
            AddRange(source);
        }

        public void AddIndex(PropertyDescriptor property)
        {
            throw new NotImplementedException();
        }

        public object AddNew()
        {
            throw new NotImplementedException();
        }

        public void ApplySort(PropertyDescriptor property, ListSortDirection direction)
        {
            SortProperty = property;
            SortDirection = direction;
            IsSorted = true;

            _comparer.Sorts = new ListSortDescriptionCollection(new ListSortDescription[] 
            {
                new ListSortDescription(property, direction)
            });

            Sort(_comparer);
            ListChanged?.Invoke(this, new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        public int Find(PropertyDescriptor property, object key)
        {
            throw new NotImplementedException();
        }

        public void RemoveIndex(PropertyDescriptor property)
        {
            throw new NotImplementedException();
        }

        public void RemoveSort()
        {
            IsSorted = false;
            SortProperty = null;
            SortDirection = ListSortDirection.Ascending;
            ListChanged?.Invoke(this, new ListChangedEventArgs(ListChangedType.Reset, -1));
        }
    }
}
