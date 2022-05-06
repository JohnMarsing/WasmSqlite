namespace WasmSqlite.Services;

using SqliteWasmHelper;
using WasmSqlite.Data;

public class ToDoService
{
	private readonly ISqliteWasmDbContextFactory<ThingContext> _dbFactory;
	public ToDoService(ISqliteWasmDbContextFactory<ThingContext> factory) => _dbFactory = factory;

	public async Task<IEnumerable<Thing>> GetTasksAsync()
	{
		using var ctx = await _dbFactory.CreateDbContextAsync();
		if (ctx.Things.Any())
		{
			ctx.Things.Add(new Thing
			{
				Name = $"Task added on {DateTime.Now}",
			});
		}
		else
		{
			ctx.Things.Add(new Thing
			{
				Name = $"Task added on {DateTime.Now}",
			});
		}
		await ctx.SaveChangesAsync();
		return ctx.Things.ToList();
	}
}