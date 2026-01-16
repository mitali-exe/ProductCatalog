using Telerik.SvgIcons;

public static class NavRoutes
{
    public static readonly List<RouteItem> Items = new()
    {
        new RouteItem("/", "Dashboard"),
        new RouteItem("/product-catalog", "Inventory"),
        new RouteItem("/analytics", "Analytics"),
        new RouteItem("/help", "Support")
    };

    public static string GetTitle(string url)
    {
        var match = Items.FirstOrDefault(i =>
            url.Equals(i.Url, StringComparison.OrdinalIgnoreCase));

        return match?.Title ?? "Page";
    }
}

public class RouteItem
{
    public RouteItem(string url, string title)
    {
        Url = url;
        Title = title;
    }

    public string Url { get; }
    public string Title { get; }
}
