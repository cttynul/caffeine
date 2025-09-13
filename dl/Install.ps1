# Display the Caffeine logo
function Print-Logo {
    Write-Host "
                       .d888  .d888         d8b                   
                      d88P   d88P           Y8P                   
                      888    888                                  
     .d8888b  8888b.  888888 888888 .d88b.  888 88888b.   .d88b.  
    d88P          88b 888    888   d8P  Y8b 888 888  88b d8P  Y8b 
    888      .d888888 888    888   88888888 888 888  888 88888888 
    Y88b.    888  888 888    888   Y8b.     888 888  888 Y8b.     
      Y8888P  Y888888 888    888     Y8888  888 888  888   Y8888  

                                                        - cttynul"
    Write-Host ""
}

# Call the function to show the logo
Print-Logo

# Get the full path where the script is being executed
$scriptPath = Get-Location

# Define the URL for the Caffeine.ps1 script on GitHub
$downloadUrl = "https://raw.githubusercontent.com/cttynul/caffeine/refs/heads/master/Powershell/Caffeine.ps1"

# Define the local file path for the downloaded script
$caffeineScriptPath = Join-Path -Path $scriptPath -ChildPath "Caffeine.ps1"

Write-Host "Downloading the latest version of Caffeine.ps1..." -ForegroundColor Yellow

# Download the script from GitHub
try {
    Invoke-WebRequest -Uri $downloadUrl -OutFile $caffeineScriptPath -UseBasicParsing
    Write-Host "Download successful! The file is located at: $caffeineScriptPath" -ForegroundColor Green
} catch {
    Write-Host "Error: Could not download Caffeine.ps1. Please check your internet connection." -ForegroundColor Red
    Write-Host $_.Exception.Message
    Write-Host "Installation failed. Press Enter to exit." -ForegroundColor Red
    [void][System.Console]::ReadKey()
    exit
}

# Configure PowerShell Profile
$profilePath = $profile

# Check if the profile's parent directory exists. If not, create it.
if (-not (Test-Path (Split-Path $profilePath))) {
    New-Item -Path (Split-Path $profilePath) -ItemType Directory -Force | Out-Null
}

# Check if the profile file exists. If not, create it.
if (-not (Test-Path $profilePath)) {
    New-Item -Path $profilePath -ItemType File -Force | Out-Null
}

# Construct the command to be added to the profile to start the script in the background.
$commandToAdd = "`nStart-Process powershell.exe -ArgumentList '-NoProfile', '-ExecutionPolicy Bypass', '-File', '""$caffeineScriptPath""', '-Wait', '240' -NoNewWindow"

# Get the profile content and check if the command is already present to avoid duplicates.
$profileContent = Get-Content $profilePath -Raw
if ($profileContent -notlike "*$commandToAdd*") {
    # Add the command to the end of the profile file.
    Add-Content -Path $profilePath -Value $commandToAdd
    Write-Host "Success: The startup command for Caffeine.ps1 has been added to your PowerShell profile." -ForegroundColor Green
} else {
    Write-Host "Info: The startup command for Caffeine.ps1 is already in your profile. No changes were made." -ForegroundColor Yellow
}

Write-Host ""
Write-Host "Installation complete. Press Enter to exit." -ForegroundColor Cyan
[void][System.Console]::ReadKey()