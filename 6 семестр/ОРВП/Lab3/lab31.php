<?php
$numberOfLine = 2;
$file = "lab31.txt";
$file_array = file("lab31.txt");
$count = 0;

$file = fopen("lab31.txt", "r");
while (!feof($file)) {
    $line = fgets($file, 4096);
    print($line);
}
fclose($file);
print("\n");

$file = fopen("lab31.txt", "w");
if (!$file_array) {
    echo ("Ошибка открытия файла");
} else {
    for ($i = 0; $i < count($file_array); $i++) {
        if($i != $numberOfLine){
            fwrite($file, $file_array[$i] . "\r");
        }
    }
}
fclose($file);


$file = fopen("lab31.txt", "r");
while (!feof($file)) {
    $line = fgets($file, 4096);
    print($line);
}
fclose($file);
