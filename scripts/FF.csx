
try {
    Environment.FailFast("Hello");
} catch {
    Console.WriteLine("Catch");
} finally {
    Console.WriteLine("This finally block will not be executed.");
}