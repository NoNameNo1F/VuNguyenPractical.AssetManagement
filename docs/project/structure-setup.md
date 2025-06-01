AssetManagement Hyper Modulith Clean setup

[Abstract] Clean Modulith + Test

sln Name: VuNguyenPractical.AssetManagement
dotnet new sln VuNguyenPractical.AssetManagement
mkdir src & cd ./src
Manually add sln BuildingBlocks, Hosts, Modules to sln 

## BuidlingBlocks

### Application

dotnet new classlib --name AssetManagement.Application --output .\BuildingBlocks\AssetManagement.Application

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\BuildingBlocks\AssetManagement.Application\AssetManagement.Application.csproj

### CrossCuttingConcerns

dotnet new classlib --name AssetManagement.CrossCuttingConcerns --output .\BuildingBlocks\AssetManagement.CrossCuttingConcerns

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\BuildingBlocks\AssetManagement.CrossCuttingConcerns\AssetManagement.CrossCuttingConcerns.csproj

### Domain

dotnet new classlib --name AssetManagement.Domain --output .\BuildingBlocks\AssetManagement.Domain

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\BuildingBlocks\AssetManagement.Domain\AssetManagement.Domain.csproj

### Infrastructure

dotnet new classlib --name AssetManagement.Infrastructure --output .\BuildingBlocks\AssetManagement.Infrastructure

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\BuildingBlocks\AssetManagement.Infrastructure\AssetManagement.Infrastructure.csproj

## Hosts

### WebAPI

dotnet new webapi --name AssetManagement.WebAPI --output .\Hosts\AssetManagement.WebAPI

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Hosts\AssetManagement.WebAPI\AssetManagement.WebAPI.csproj

### Migrator

dotnet new webapi --name AssetManagement.Migrator --output .\Hosts\AssetManagement.Migrator

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Hosts\AssetManagement.Migrator\AssetManagement.Migrator.csproj

### BackgroundServer

dotnet new webapi --name AssetManagement.BackgroundServer --output .\Hosts\AssetManagement.BackgroundServer\AssetManagement.BackgroundServer.csproj

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Hosts\AssetManagement.BackgroundServer\AssetManagement.BackgroundServer.csproj

## Modules

### Assets

#### Application

dotnet new classlib --name AssetManagement.Modules.Assets.Application --output .\Modules\Assets\AssetManagement.Modules.Assets.Application

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Assets\AssetManagement.Modules.Assets.Application\AssetManagement.Modules.Assets.Application.csproj	

#### Domain

dotnet new classlib --name AssetManagement.Modules.Assets.Domain --output .\Modules\Assets\AssetManagement.Modules.Assets.Domain

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Assets\AssetManagement.Modules.Assets.Domain\AssetManagement.Modules.Assets.Domain.csproj

#### Infrastructure

dotnet new classlib --name AssetManagement.Modules.Assets.Infrastructure --output .\Modules\Assets\AssetManagement.Modules.Assets.Infrastructure

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Assets\AssetManagement.Modules.Assets.Infrastructure\AssetManagement.Modules.Assets.Infrastructure.csproj

#### IntegrationEvents

dotnet new classlib --name AssetManagement.Modules.Assets.IntegrationEvents --output .\Modules\Assets\AssetManagement.Modules.Assets.IntegrationEvents

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Assets\AssetManagement.Modules.Assets.IntegrationEvents\AssetManagement.Modules.Assets.IntegrationEvents.csproj

#### Tests

dotnet new sln Tests => AssetManagement.Modules.Assets/Tests

##### ArchTests

dotnet new xunit --name AssetManagement.Modules.Assets.ArchTests --output .\Modules\Assets\Tests\AssetManagement.Modules.Assets.ArchTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Assets\Tests\AssetManagement.Modules.Assets.ArchTests\AssetManagement.Modules.Assets.ArchTests.csproj

##### Domain.UnitTests

dotnet new xunit --name AssetManagement.Modules.Assets.Domain.UnitTests --output .\Modules\Assets\Tests\AssetManagement.Modules.Assets.Domain.UnitTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Assets\Tests\AssetManagement.Modules.Assets.Domain.UnitTests\AssetManagement.Modules.Assets.Domain.UnitTests.csproj

##### Application.UnitTests

dotnet new xunit --name AssetManagement.Modules.Assets.Application.UnitTests --output .\Modules\Assets\Tests\AssetManagement.Modules.Assets.Application.UnitTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Assets\Tests\AssetManagement.Modules.Assets.Application.UnitTests\AssetManagement.Modules.Assets.Application.UnitTests.csproj

##### IntegrationTests

dotnet new xunit --name AssetManagement.Modules.Assets.IntegrationTests --output .\Modules\Assets\Tests\AssetManagement.Modules.Assets.IntegrationTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Assets\Tests\AssetManagement.Modules.Assets.IntegrationTests\AssetManagement.Modules.Assets.IntegrationTests.csproj

### Assignments

#### Application

dotnet new classlib --name AssetManagement.Modules.Assignments.Application --output .\Modules\Assignments\AssetManagement.Modules.Assignments.Application

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Assignments\AssetManagement.Modules.Assignments.Application\AssetManagement.Modules.Assignments.Application.csproj

#### Domain

dotnet new classlib --name AssetManagement.Modules.Assignments.Domain --output .\Modules\Assignments\AssetManagement.Modules.Assignments.Domain

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Assignments\AssetManagement.Modules.Assignments.Domain\AssetManagement.Modules.Assignments.Domain.csproj

#### Infrastructure

dotnet new classlib --name AssetManagement.Modules.Assignments.Infrastructure --output .\Modules\Assignments\AssetManagement.Modules.Assignments.Infrastructure

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Assignments\AssetManagement.Modules.Assignments.Infrastructure\AssetManagement.Modules.Assignments.Infrastructure.csproj

#### IntegrationEvents

dotnet new classlib --name AssetManagement.Modules.Assignments.IntegrationEvents --output .\Modules\Assignments\AssetManagement.Modules.Assignments.IntegrationEvents

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Assignments\AssetManagement.Modules.Assignments.IntegrationEvents\AssetManagement.Modules.Assignments.IntegrationEvents.csproj

#### Tests

# dotnet new sln Tests => AssetManagement.Modules.Assignments/Tests

##### ArchTests

dotnet new xunit --name AssetManagement.Modules.Assignments.ArchTests --output .\Modules\Assignments\Tests\AssetManagement.Modules.Assignments.ArchTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Assignments\Tests\AssetManagement.Modules.Assignments.ArchTests\AssetManagement.Modules.Assignments.ArchTests.csproj

##### Domain.UnitTests

dotnet new xunit --name AssetManagement.Modules.Assignments.Domain.UnitTests --output .\Modules\Assignments\Tests\AssetManagement.Modules.Assignments.Domain.UnitTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Assignments\Tests\AssetManagement.Modules.Assignments.Domain.UnitTests\AssetManagement.Modules.Assignments.Domain.UnitTests.csproj

##### Application.UnitTests

dotnet new xunit --name AssetManagement.Modules.Assignments.Application.UnitTests --output .\Modules\Assignments\Tests\AssetManagement.Modules.Assignments.Application.UnitTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Assignments\Tests\AssetManagement.Modules.Assignments.Application.UnitTests\AssetManagement.Modules.Assignments.Application.UnitTests.csproj

##### IntegrationTests

dotnet new xunit --name AssetManagement.Modules.Assignments.IntegrationTests --output .\Modules\Assignments\Tests\AssetManagement.Modules.Assignments.IntegrationTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Assignments\Tests\AssetManagement.Modules.Assignments.IntegrationTests\AssetManagement.Modules.Assignments.IntegrationTests.csproj

### Returnings

#### Application

dotnet new classlib --name AssetManagement.Modules.Returnings.Application --output .\Modules\Returnings\AssetManagement.Modules.Returnings.Application

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Returnings\AssetManagement.Modules.Returnings.Application\AssetManagement.Modules.Returnings.Application.csproj

#### Domain

dotnet new classlib --name AssetManagement.Modules.Returnings.Domain --output .\Modules\Returnings\AssetManagement.Modules.Returnings.Domain

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Returnings\AssetManagement.Modules.Returnings.Domain\AssetManagement.Modules.Returnings.Domain.csproj

#### Infrastructure

dotnet new classlib --name AssetManagement.Modules.Returnings.Infrastructure --output .\Modules\Returnings\AssetManagement.Modules.Returnings.Infrastructure

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Returnings\AssetManagement.Modules.Returnings.Infrastructure\AssetManagement.Modules.Returnings.Infrastructure.csproj

#### IntegrationEvents

dotnet new classlib --name AssetManagement.Modules.Returnings.IntegrationEvents --output .\Modules\Returnings\AssetManagement.Modules.Returnings.IntegrationEvents

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Returnings\AssetManagement.Modules.Returnings.IntegrationEvents\AssetManagement.Modules.Returnings.IntegrationEvents.csproj

#### Tests

# dotnet new sln Tests => AssetManagement.Modules.Returnings/Tests

##### ArchTests

dotnet new xunit --name AssetManagement.Modules.Returnings.ArchTests --output .\Modules\Returnings\Tests\AssetManagement.Modules.Returnings.ArchTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Returnings\Tests\AssetManagement.Modules.Returnings.ArchTests\AssetManagement.Modules.Returnings.ArchTests.csproj

##### Domain.UnitTests

dotnet new xunit --name AssetManagement.Modules.Returnings.Domain.UnitTests --output .\Modules\Returnings\Tests\AssetManagement.Modules.Returnings.Domain.UnitTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Returnings\Tests\AssetManagement.Modules.Returnings.Domain.UnitTests\AssetManagement.Modules.Returnings.Domain.UnitTests.csproj

##### Application.UnitTests

dotnet new xunit --name AssetManagement.Modules.Returnings.Application.UnitTests --output .\Modules\Returnings\Tests\AssetManagement.Modules.Returnings.Application.UnitTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Returnings\Tests\AssetManagement.Modules.Returnings.Application.UnitTests\AssetManagement.Modules.Returnings.Application.UnitTests.csproj

##### IntegrationTests

dotnet new xunit --name AssetManagement.Modules.Returnings.IntegrationTests --output .\Modules\Returnings\Tests\AssetManagement.Modules.Returnings.IntegrationTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Returnings\Tests\AssetManagement.Modules.Returnings.IntegrationTests\AssetManagement.Modules.Returnings.IntegrationTests.csproj

### Report

#### Application

dotnet new classlib --name AssetManagement.Modules.Report.Application --output .\Modules\Report\AssetManagement.Modules.Report.Application

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Report\AssetManagement.Modules.Report.Application\AssetManagement.Modules.Report.Application.csproj

#### Domain

dotnet new classlib --name AssetManagement.Modules.Report.Domain --output .\Modules\Report\AssetManagement.Modules.Report.Domain

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Report\AssetManagement.Modules.Report.Domain\AssetManagement.Modules.Report.Domain.csproj

#### Infrastructure

dotnet new classlib --name AssetManagement.Modules.Report.Infrastructure --output .\Modules\Report\AssetManagement.Modules.Report.Infrastructure

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Report\AssetManagement.Modules.Report.Infrastructure\AssetManagement.Modules.Report.Infrastructure.csproj

#### IntegrationEvents (May not be used)

dotnet new classlib --name AssetManagement.Modules.Report.IntegrationEvents --output .\Modules\Report\AssetManagement.Modules.Report.IntegrationEvents

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Report\AssetManagement.Modules.Report.IntegrationEvents\AssetManagement.Modules.Report.IntegrationEvents.csproj

#### Tests

# dotnet new sln Tests => AssetManagement.Modules.Report/Tests

##### ArchTests

dotnet new xunit --name AssetManagement.Modules.Report.ArchTests --output .\Modules\Report\Tests\AssetManagement.Modules.Report.ArchTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Report\Tests\AssetManagement.Modules.Report.ArchTests\AssetManagement.Modules.Report.ArchTests.csproj

##### Domain.UnitTests

dotnet new xunit --name AssetManagement.Modules.Report.Domain.UnitTests --output .\Modules\Report\Tests\AssetManagement.Modules.Report.Domain.UnitTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Report\Tests\AssetManagement.Modules.Report.Domain.UnitTests\AssetManagement.Modules.Report.Domain.UnitTests.csproj

##### Application.UnitTests

dotnet new xunit --name AssetManagement.Modules.Report.Application.UnitTests --output .\Modules\Report\Tests\AssetManagement.Modules.Report.Application.UnitTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Report\Tests\AssetManagement.Modules.Report.Application.UnitTests\AssetManagement.Modules.Report.Application.UnitTests.csproj

##### IntegrationTests

dotnet new xunit --name AssetManagement.Modules.Report.IntegrationTests --output .\Modules\Report\Tests\AssetManagement.Modules.Report.IntegrationTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Report\Tests\AssetManagement.Modules.Report.IntegrationTests\AssetManagement.Modules.Report.IntegrationTests.csproj

### Identity

#### Application

dotnet new classlib --name AssetManagement.Modules.Identity.Application --output .\Modules\Identity\AssetManagement.Modules.Identity.Application

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Identity\AssetManagement.Modules.Identity.Application\AssetManagement.Modules.Identity.Application.csproj

#### Domain

dotnet new classlib --name AssetManagement.Modules.Identity.Domain --output .\Modules\Identity\AssetManagement.Modules.Identity.Domain

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Identity\AssetManagement.Modules.Identity.Domain\AssetManagement.Modules.Identity.Domain.csproj

#### Infrastructure

dotnet new classlib --name AssetManagement.Modules.Identity.Infrastructure --output .\Modules\Identity\AssetManagement.Modules.Identity.Infrastructure

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Identity\AssetManagement.Modules.Identity.Infrastructure\AssetManagement.Modules.Identity.Infrastructure.csproj

#### IntegrationEvents (May not be used)

dotnet new classlib --name AssetManagement.Modules.Identity.IntegrationEvents --output .\Modules\Identity\AssetManagement.Modules.Identity.IntegrationEvents

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Identity\AssetManagement.Modules.Identity.IntegrationEvents\AssetManagement.Modules.Identity.IntegrationEvents.csproj

#### Tests

# dotnet new sln Tests => AssetManagement.Modules.Identity/Tests

##### ArchTests

dotnet new xunit --name AssetManagement.Modules.Identity.ArchTests --output .\Modules\Identity\Tests\AssetManagement.Modules.Identity.ArchTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Identity\Tests\AssetManagement.Modules.Identity.ArchTests\AssetManagement.Modules.Identity.ArchTests.csproj

##### Domain.UnitTests

dotnet new xunit --name AssetManagement.Modules.Identity.Domain.UnitTests --output .\Modules\Identity\Tests\AssetManagement.Modules.Identity.Domain.UnitTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Identity\Tests\AssetManagement.Modules.Identity.Domain.UnitTests\AssetManagement.Modules.Identity.Domain.UnitTests.csproj

##### Application.UnitTests

dotnet new xunit --name AssetManagement.Modules.Identity.Application.UnitTests --output .\Modules\Identity\Tests\AssetManagement.Modules.Identity.Application.UnitTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Identity\Tests\AssetManagement.Modules.Identity.Application.UnitTests\AssetManagement.Modules.Identity.Application.UnitTests.csproj

##### IntegrationTests

dotnet new xunit --name AssetManagement.Modules.Identity.IntegrationTests --output .\Modules\Identity\Tests\AssetManagement.Modules.Identity.IntegrationTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Modules\Identity\Tests\AssetManagement.Modules.Identity.IntegrationTests\AssetManagement.Modules.Identity.IntegrationTests.csproj

## Tests

### AssetManagement.ArchTests

dotnet new xunit --name AssetManagement.ArchTests --output .\Tests\AssetManagement.ArchTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Tests\AssetManagement.ArchTests\AssetManagement.ArchTests.csproj

### AssetManagement.IntegrationTests

dotnet new xunit --name AssetManagement.IntegrationTests --output .\Tests\AssetManagement.IntegrationTests

dotnet sln .\VuNguyenPractical.AssetManagement.sln add .\Tests\AssetManagement.IntegrationTests\AssetManagement.IntegrationTests.csproj
