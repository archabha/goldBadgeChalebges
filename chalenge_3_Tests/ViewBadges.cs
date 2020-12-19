using System.Collections.Generic;

internal class ViewBadges
{
    private int v1;
    private string v2;
    private List<string> lists;

    public ViewBadges(int v1, string v2, List<string> lists)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.lists = lists;
    }

    public bool HasAccessTo { get; internal set; }
}