using System.IO;
using GitPsProject.Model;
using System.Management.Automation;


public class Table{
    public async void AddOnTable(DateTime date, string directory){
        GitPsProjectContext context = new GitPsProjectContext();
        var files = 
            from file in context.Arquivos
            select file;
        var searchFile = files.FirstOrDefault(file => file.Diretorio == directory);

        System.Console.WriteLine(searchFile is null);

        if(searchFile is null)
            await createFile(date, directory, context);
        else
            await updateFile(searchFile, context);

    }


    async Task createFile(DateTime date, string directory, GitPsProjectContext table)
    {
        Arquivo File = new Arquivo();
        File.DataEnvio = date;
        File.Diretorio = directory;
        table.Add(File);
        await table.SaveChangesAsync();
    }


    async Task updateFile(Arquivo arquivo, GitPsProjectContext table)
    {
        arquivo.DataEnvio = DateTime.Now;
        await table.SaveChangesAsync();
    }
}