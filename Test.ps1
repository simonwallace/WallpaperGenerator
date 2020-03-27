$testFolders = Get-ChildItem $PSScriptRoot -Directory | Where-Object { $_.Name.Contains('.Tests.') }

Write-Host "Removing old test results..."

foreach ($testFolder in $testFolders) {

    $testResult = Join-Path $testFolder.FullName 'TestResults'

    if (Test-Path $testResult) {

        Write-Host "- $($testFolder.Name)"
        Remove-Item $testResult -Recurse
    }
}

Write-Host

dotnet test --collect:"XPlat Code Coverage"
