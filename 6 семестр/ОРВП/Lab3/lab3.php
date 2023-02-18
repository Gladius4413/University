<?php
$file = "lab3.txt";
$info = "InfoInfoInfoInfoInfoInfo";


if (is_file($file)) {
    print("File exists\n");
} else {
    print("File doesn't exists\n");
}


if (is_readable($file)) {
    print("File is readable\n");
} else {
    print("File isn't readable\n");
}


if (is_writable($file)) {
    print("File is writable\n");
} else {
    print("File isn't writable\n");
}


$fileSize = filesize($file);
print("Size of File = $fileSize bytes\n");


$file = fopen("lab3.txt", "r");
while (!feof($file)) {
    $line = fgets($file, 4096);
    print($line);
}
fclose($file);
print("\n");

$file = fopen("lab3.txt", "a");
fwrite($file, $info . "\r\n");
fclose($file);


$file = fopen("lab3.txt", "r");
while (!feof($file)) {
    $line = fgets($file, 4096);
    print($line);
}
fclose($file);
print("\n");


