<?php
$file_array = file("lab3.txt");
if (!$file_array) {
    echo ("Ошибка открытия файла");
} else {
    for ($i = 0; $i < count($file_array); $i++) {
        printf("%s<br>", $file_array[$i]);
    }
}
