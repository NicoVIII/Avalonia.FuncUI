#r "../_lib/Fornax.Core.dll"

type Page = {
    title: string
    link: string
}

let loader (projectRoot: string) (siteContent: SiteContents) =
    siteContent.Add({title = "Home"; link = "/"})
    siteContent.Add({title = "Guides"; link = "/guides.html"})
    siteContent.Add({title = "About"; link = "/about.html"})

    siteContent