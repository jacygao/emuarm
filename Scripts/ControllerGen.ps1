# Prompt user for paths
$openApiSpecPath = "./OpenApi/Specs"
$outputPath = "./Emu/Controllers/"

# Check if NSwag is installed
if (-not (Get-Command nswag -ErrorAction SilentlyContinue)) {
    Write-Host "NSwag is not installed. Installing NSwag CLI..."
    dotnet tool install -g NSwag.ConsoleCore
}

# Get all subdirectories in the OpenAPI spec path
$specDirectories = Get-ChildItem -Directory -Path $openApiSpecPath

foreach ($dir in $specDirectories) {
    # Get all files in the subdirectory
    Write-Host "dir is $dir"
    $specFiles = Get-ChildItem -File -Path $dir

    $foldername = Split-Path -Path $dir -Leaf

    # Loop through each subdirectory and generate controllers
    foreach ($file in $specFiles) {
        Write-Host "file name: $file"
        $fileFullName = Split-Path -Path $file -Leaf
        if ($fileFullName.Contains("common") -or $fileFullName.Contains("Common")) {
            continue
        }
        
        $fileName = [System.IO.Path]::GetFileNameWithoutExtension($file.Name)
        $subFolderName = $fileName.Substring(0,1).ToUpper() + $fileName.Substring(1) + "Controller"

        $controllerName = $subFolderName + ".cs"

        $outputFilePath = Join-Path $outputPath $foldername
        Write-Host "output $outputFilePath"

        # Create folder if not already existing
        if (-not (Test-Path -Path $outputFilePath -PathType Container)) {
            New-Item -Path $outputFilePath -ItemType Directory -Force
        }

        $outputFilePath = Join-Path $outputFilePath $subFolderName $controllerName

        # Run NSwag to generate controller
        Write-Host "Generating controller $controllerName from OpenAPI spec in $outputFilePath..."
        nswag openapi2cscontroller /input:$file /output:$outputFilePath /namespace:$subFolderName

        # Check if the file was generated
        if (Test-Path $outputFilePath) {
            Write-Host "Controller generated successfully: $outputFilePath"
        } else {
            Write-Host "Failed to generate controller for $file.FullName."
        }
    }
}