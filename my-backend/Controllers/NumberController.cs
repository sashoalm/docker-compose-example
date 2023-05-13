using Microsoft.AspNetCore.Mvc;
using MySqlConnector;

namespace my_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class NumberController : ControllerBase
{
    private readonly MySqlConnection _conn;

    public NumberController(MySqlConnection conn)
    {
        _conn = conn;
    }

    [HttpGet()]
    public async Task<List<int>> Get()
    {
        await _conn.OpenAsync();
        var command = new MySqlCommand("select * from MyTable", _conn);
        var numbers = new List<int>();
        var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync()) {
            numbers.Add(reader.GetInt32(0));
        }

        return numbers;
    }

    [HttpPost()]
    public async Task Post([FromBody] int number)
    {
        await _conn.OpenAsync();
        var command = new MySqlCommand("insert into MyTable values(@val)", _conn);
        command.Parameters.AddWithValue("@val", number);
        await command.ExecuteNonQueryAsync();
    }
}
