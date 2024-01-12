namespace Extensibility;

class DbMigrator
{
    private readonly ILogger _logger;

    public DbMigrator(ILogger logger)
    {
        _logger = logger;
    }
    public void Migrate()
    {
        _logger.LogInfo($"Migration started at {DateTime.Now}");
        // Migration
        _logger.LogInfo($"Migration finished at {DateTime.Now}");
    }
}