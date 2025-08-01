[HttpPost]
// [ValidateAntiForgeryToken] // Temporarily comment this out for testing
public async Task<IActionResult> Login(string? returnUrl, LoginVM model)
{
    // ... rest of the method
}