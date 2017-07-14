# GfyCatSharp
In progress. A partial implementation of the GFYCat API. Includes support for many API endpoints.

Building this as I go. Currently supporting:

Initialize agent before any requests can be made.

GFYCatSharp.Agent agent = new GFYCatSharp.Agent("#CLIENTID#", "#SECRETID#");


# GetImageUrlById(string gfyId, EImageType type)
Get an image from GfyCat by GfyCat Id (string).

# GetItemsByTag(string tag, int take = 10)
Gets, by default, 10 images from GFYCat with the given tag.
