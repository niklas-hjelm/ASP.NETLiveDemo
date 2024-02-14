var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<PeopleStorage>();
builder.Services.AddScoped<PeopleStorage>();
builder.Services.AddSingleton<PeopleStorage>();

var app = builder.Build();

app.MapGet("/{id}", (int id) => id);

app.Run();

record Person(string Name);

class PeopleStorage
{
    public List<Person> People { get; set; }
    public void AddPerson(Person person)
    {
        // Add person to the list
    }

    public void UpdatePerson(Person person)
    {
        // Update person in the list
    }

    public void DeletePerson(int id)
    {
        // Delete person from the list based on ID
    }

    public Person GetPerson(int id)
    {
        // Get person from the list based on ID
        return null;
    }
}
