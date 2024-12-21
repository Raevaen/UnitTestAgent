# Restore and Test
dotnet restore
dotnet test --collect:"XPlat Code Coverage"

# Find Coverage File
$coverageFile = Get-ChildItem -Recurse -Filter "coverage.cobertura.xml" | Select-Object -First 1

# Extract Line and Branch Coverage
$coverageXml = [xml](Get-Content $coverageFile.FullName)
$lineCoverage = $coverageXml.coverage.'@line-rate'
$branchCoverage = $coverageXml.coverage.'@branch-rate'

# Convert to Percentages
$lineCoveragePercent = [math]::Round($lineCoverage * 100, 2)
$branchCoveragePercent = [math]::Round($branchCoverage * 100, 2)

# Output Results
Write-Host "Line Coverage: $lineCoveragePercent%"
Write-Host "Branch Coverage: $branchCoveragePercent%"
