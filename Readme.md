
Project for [Class project why need add Microsoft.AspNetCore.MVC ProjectReference in aspnetcore2.2 if already included Microsoft.AspNetCore.App 2.2.0 · Issue #8546 · aspnet/AspNetCore](https://github.com/aspnet/AspNetCore/issues/8546)

---

> Test TargetFramework : netcoreapp2.1;netcoreapp2.2;

If ControllerLib.csproj only reference `Microsoft.AspNetCore.App` without version,it'll get `HTTP ERROR 404`.

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFrameworks>netcoreapp2.1;netcoreapp2.2;</TargetFrameworks>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.App"/>
  </ItemGroup>
</Project>
```
![20190320095734-image.png](https://raw.githubusercontent.com/shps951023/ImageHosting/master/img/20190320095734-image.png)
![20190320100007-image.png](https://raw.githubusercontent.com/shps951023/ImageHosting/master/img/20190320100007-image.png)


---


I have to ControllerLib.csproj add explicit reference `<PackageReference Include="Microsoft.AspNetCore.MVC" />` to run web successfully.



```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFrameworks>netcoreapp2.1;netcoreapp2.2;</TargetFrameworks>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.App"/>
    <PackageReference Include="Microsoft.AspNetCore.MVC" />
  </ItemGroup>
</Project>
```

![20190320100429-image.png](https://raw.githubusercontent.com/shps951023/ImageHosting/master/img/20190320100429-image.png)