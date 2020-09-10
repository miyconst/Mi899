using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Mi899.Data;

namespace Mi899
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using var services = new ServiceCollection()
                .AddSingleton<I18n>(I18n.LoadFromJson())
                .AddSingleton<Model>(Model.LoadFromJson())
                .AddSingleton<MainForm>()
                .AddTransient<ReadMePartialForm>()
                .AddTransient<BiosesPartialForm>()
                .AddTransient<MotherboardPartialForm>()
                .AddTransient<MotherboardsPartialForm>()
                .BuildServiceProvider();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            MainForm frm = services.GetRequiredService<MainForm>();
            Application.Run(frm);
        }
    }
}
