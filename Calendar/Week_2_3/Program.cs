using Week_2_3MX.Entites;
Console.WriteLine("Calendar App");


Meeting meeting1 = new()
{
    Id = Guid.NewGuid(),
    Title = "Staj Sunum",
    Details = new List<string> {
        "sunum yapma"},
    StartTime = new DateTime(2023, 09, 28, 19, 00, 00),
    FinishTime = new DateTime(2023, 09, 28, 20, 00, 00),
    Guests = new() { "celalkarahan@mx.com", "muyux@mx.com" }
};

Todo todo1 = new()
{
    Id = Guid.NewGuid(),
    Title = "Sunum kontrol",
    Details = new List<string> {
        "sunum değerlenddirme",},
    StartTime = new DateTime(2023, 09, 25, 21, 00, 00),
    FinishTime = new DateTime(2023, 09, 25, 22, 00, 00),
    Importance = "high priority"
};

meeting1.GetNotification();
todo1.GetNotification();
