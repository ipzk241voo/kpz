using ConsoleApp.Task1.Class;
using ConsoleApp.Task1;

Logger logger = new Logger();
logger.Log("Test log");
logger.Error("Test error");
logger.Warn("Test warn");

FileWriter writer = new FileWriter("log.txt");
FileLoggerAdapter fileLogger = new FileLoggerAdapter(writer);

fileLogger.Log("Test log");
fileLogger.Error("Test error");
fileLogger.Warn("Test Warn");