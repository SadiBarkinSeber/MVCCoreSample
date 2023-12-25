var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();// Http isteklerini HTTPS yönlendirmesi yapar
app.UseStaticFiles();//Client-side kütüphanelerini kullanmaya izin verir

app.UseRouting();

app.UseAuthorization();//Yetkilendirme varsa bu uygulamada kullanımına izin verir
app.UseStatusCodePages();//HTTP Durumu kodu(400 ile 599 arasında durumlar) sayfalarını gösterir

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
