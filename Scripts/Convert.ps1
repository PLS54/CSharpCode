param(
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()] [String]$DirToConvert
)
function Convert-Video
{
param(
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()] [String]$FileToConvert
)
     #$cmd += " `"{0}`" -f dvd -vf `"scale=720:404,pad=720:406:0:0:0x000000,setdar=16/9`"" -f $target
    $fname = Split-Path $FileToConvert -Leaf
    Write-Output ("Convering: {0}" -f $fname)
    $path = Split-Path $FileToConvert -Parent
    $target = Join-Path -Path $path -ChildPath ("_{0}" -f $fname)
    if (Test-Path $target)
    {
        Remove-Item $target
    }
    $vcodec = "mpeg2video"
    $vcodec = "h264"
    
    $acodec = "dts"
    $acodec = "aac"
    $acodec = "ac3"

    $format = "dvd"
    $format = "matroska"

    $vf = "`"scale=1920:1080,pad=1920:1082:0:0:0x000000,setdar=16/9`""
    #$vf = "`"scale=720:302,pad=720:406:0:52:0x000000,setdar=16/9`""
    $vf = "`"scale=1920:804,pad=1920:804:0:0:0x000000,setdar=160/67 `""
    Rename-Item -Path $FileToConvert -NewName $target

    $cmd ="`"C:\Program Files (x86)\Wild Media Server\wmsmpeg.exe`" " 
    $cmd += "-loglevel fatal -y -probesize 7000000 -analyzeduration 10000000 -fix_sub_duration "
    $cmd += "-i `"{0}`" "  -f ($target)
    $cmd += "-f {0} " -f ($format)
    #$cmd += "-vf {1}" -f ($vf)
    $cmd += " -vcodec {0} -b:v 3504332 -pix_fmt yuv420p -threads 8 -acodec {1} -ab 448000 -ar 48000 -ac 6 -scodec subrip -vstreamid 0 -astreamid 2 `"{2}`"" -f ($vcodec, $acodec, $FileToConvert)
    Invoke-Expression "& $cmd" 
    #Remove-Item $target
}
$files = Get-ChildItem -Path $DirToConvert
Foreach ($file in $files)
{
    Convert-Video (Join-Path -Path $DirToConvert -ChildPath $file)
}