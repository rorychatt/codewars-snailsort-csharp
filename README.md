Used commands for setup:

```
dotnet new sln -n Solution
dotnet new classlib -n Solution
dotnet new xunit -n SolutionTest
dotnet sln Solution.sln add Solution/Solution.csproj
dotnet sln Solution.sln add SolutionTest/SolutionTest.csproj
dotnet add SolutionTest/SolutionTest.csproj reference Solution/Solution.csproj
```