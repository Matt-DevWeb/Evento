using Evento.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


var app = builder.Build();
app.UseStaticFiles(); 
app.UseRouting();



app.UseEndpoints(endpoints =>
{

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Event}/{action=EventsList}/{id?}");
});

using (IDal dal = new Dal())
{
    dal.DeleteCreateDatabase();
    dal.AddEvent("Soirée Halloween", "Soirée déguisée", new DateTime(2021, 10, 31), new DateTime(2021, 10, 31), 10, 100, "halloween.jpg", 1, 2);
    dal.AddEvent("Concert de Rock", "Un concert de rock incroyable.", new DateTime(2023, 11, 1), new DateTime(2023, 11, 1), 50.0f, 200, "rock_concert.jpg", 1, 3);

    dal.UpdateEvent(1, "Soirée Halloween", "Soirée déguisée de ouf", new DateTime(2021, 10, 31), new DateTime(2021, 10, 31), 10, 100, "halloween.jpg", 1, 2);
    dal.DeleteEvent(2);
    dal.DeleteEvent(2);

    dal.GetEventByName("Soirée Halloween");
}

app.Run();
