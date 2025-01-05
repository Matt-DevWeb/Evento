using Evento.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


var app = builder.Build();
app.UseStaticFiles(); 
app.UseRouting();

using (BddContext ctx = new BddContext())
{
    ctx.InitializeDb();

}

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "AssociationForm",
      pattern: "Association/Ajouter",
      defaults: new { controller = "Association", action = "AddAssociationForm" });

    endpoints.MapControllerRoute(
       name: "Association",
       pattern: "Association/{id}",
       defaults: new { controller = "Association", action = "AssociationDetails" });

    endpoints.MapControllerRoute(
       name: "Association",
       pattern: "ListeDesAssociations",
       defaults: new { controller = "Association", action = "AssociationsList" });

    endpoints.MapControllerRoute(
       name: "Event",
       pattern: "Évènement/{id}",
       defaults: new { controller = "Event", action = "EventDetails" });

    endpoints.MapControllerRoute(
       name: "Event",
       pattern: "ListeDesEvenements",
       defaults: new { controller = "Event", action = "EventsList" });

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}");
});

using (IDal dal = new Dal())
{
    dal.DeleteCreateDatabase();
    
    dal.DeleteEvent(2);
    dal.DeleteEvent(2);
    //dal.InitializeDatabase();
    dal.GetEventByName("Soirée Halloween");
}

app.Run();
