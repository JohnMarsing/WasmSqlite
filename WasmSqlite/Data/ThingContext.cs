﻿using Microsoft.EntityFrameworkCore;

namespace WasmSqlite.Data;

public class ThingContext : DbContext
{
	public ThingContext(DbContextOptions<ThingContext> opts) : base(opts)
	{

	}

	public DbSet<Thing> Things { get; set; } = null!;
}

