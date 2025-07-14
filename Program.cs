using ApontaMe.Data;
using ApontaMe.Forms;

namespace ApontaMe;

static class Program
{
     
    [STAThread]
    static void Main()
    {
        using (var db = new AppDbContext())
        {
            db.Database.EnsureCreated();
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmInicial(db));
        }
    }
}