﻿using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index() => this.Content("Hello");
}