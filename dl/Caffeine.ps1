param([int]$Wait)

if($Wait -le 0){
    $Wait = 60
}

function printLogo($Time){
    Write-Host "

                       .d888  .d888         d8b                   
                      d88P   d88P           Y8P                   
                      888    888                                  
     .d8888b  8888b.  888888 888888 .d88b.  888 88888b.   .d88b.  
    d88P          88b 888    888   d8P  Y8b 888 888  88b d8P  Y8b 
    888      .d888888 888    888   88888888 888 888  888 88888888 
    Y88b.    888  888 888    888   Y8b.     888 888  888 Y8b.     
      Y8888P  Y888888 888    888     Y8888  888 888  888   Y8888  

                                                        - cttynul
    Timeout set to $Time Seconds       
    "
}

printLogo($Wait)
While(1) {
    [void][System.Reflection.Assembly]::LoadWithPartialName('System.Windows.Forms')
    [System.Windows.Forms.SendKeys]::SendWait("{F15}")
    Start-Sleep -Seconds $Wait
}