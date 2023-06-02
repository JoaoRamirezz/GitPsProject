using System.IO;
using GitPsProject.Model;
using System.Management.Automation;


var path = "C:/Users/disrct/Desktop";
var ls = Directory.EnumerateDirectories(path, "*", SearchOption.AllDirectories);


Table table = new Table();
Git git = new Git(); 


foreach (var f in ls)
{
    if(f.EndsWith(".git"))
    {
        var date = DateTime.Now;
        table.AddOnTable(date,f);
    }
}
