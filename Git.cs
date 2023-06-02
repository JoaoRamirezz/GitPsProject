using System.IO;
using GitPsProject.Model;
using System.Management.Automation;

public class Git{
    public void Clone (string repository){
        using var ps = PowerShell.Create();
        ps
            .AddCommand("git")
            .AddArgument("clone")
            .AddArgument($"{repository}");
    }


    public void Pull (){
        using var ps = PowerShell.Create();
        ps
            .AddCommand("git")
            .AddArgument("pull");
    }


    public void Push(string remote = "", string branch = ""){
        using var ps = PowerShell.Create();
        ps
            .AddCommand("git")
            .AddArgument("push")
            .AddArgument($"{remote}")
            .AddArgument($"{branch}");
    }


    public void Add(){
        using var ps = PowerShell.Create();
        ps
            .AddCommand("git")
            .AddArgument("add .");
    }


    public void Commit(string name = ""){
        using var ps = PowerShell.Create();
        ps
            .AddCommand("git")
            .AddArgument($"commit -m {name}");
    }
    
}