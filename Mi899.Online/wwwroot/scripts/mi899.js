document.Mi899 = {
    dataRepositoryUrl: "https://raw.githubusercontent.com/miyconst/Mi899/refs/heads/master/src/Mi899.Data/",
    modelUrl: "https://raw.githubusercontent.com/miyconst/Mi899/refs/heads/master/src/Mi899.Data/Model.json",
    i18nUrl: "https://raw.githubusercontent.com/miyconst/Mi899/refs/heads/master/src/Mi899.Data/I18n.json",
    readmeUrl: "https://raw.githubusercontent.com/miyconst/Mi899/refs/heads/master/src/Mi899/README.md"
};

{
    const activateNav = function () {
        const navs = document.querySelectorAll("nav a.nav-link");
        const url = document.URL;

        Array.prototype.forEach.call(navs, (a) => {
            const href = a.getAttribute("href");

            if (url.endsWith(href) || href == document.mi899NavPage) {
                a.classList.add("active");
                a.classList.add("fw-bold");
            }
        });
    };

    const templates = document.querySelectorAll("div.mi899-template");
    Array.prototype.forEach.call(templates, (div) => {
        const href = div.getAttribute("href");

        fetch(href)
            .then(r => r.text())
            .then(html => {
                div.innerHTML = html;
                div.setAttribute("loaded", "");

                if (href == "nav.html") {
                    activateNav();
                }
            });
    });
}