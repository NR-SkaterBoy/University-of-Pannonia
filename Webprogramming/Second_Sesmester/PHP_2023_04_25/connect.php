<?php
if ($_SERVER['REQUEST_METHOD'] && isset($_POST['submit'])) {
    // Adatbázis kapcsolat
    $conn = mysqli_connect('localhost', 'root', '', 'test') or die('Connection failed: ' . mysqli_connect_error());
    
    // Ellenőrzés és adatok kezelése
    $name = mysqli_real_escape_string($conn, $_POST['name']);
    $pwd = mysqli_real_escape_string($conn, $_POST['pwd']);
    $angol = isset($_POST['angol']) ? 1 : 0;
    $nemet = isset($_POST['nemet']) ? 1 : 0;
    $francia = isset($_POST['francia']) ? 1 : 0;
    $datum = mysqli_real_escape_string($conn, $_POST['date']);
    $cikk = mysqli_real_escape_string($conn, $_POST['cikk']);
    
    // Validáció
    $errors = [];
    if (empty($name)) {
        $errors[] = "Név mező kötelező";
    }
    if (empty($pwd)) {
        $errors[] = "Jelszó mező kötelező";
    }
    if (empty($datum)) {
        $errors[] = "Dátum mező kötelező";
    }
    if (count($errors) > 0) {
        foreach ($errors as $error) {
            echo $error . "<br>";
        }
        exit();
    }
    
    // Adatok beszúrása
    $sql = "INSERT INTO `ora0425` (`ID`, `Név`, `Jelszó`, `Angol`, `Német`, `Francia`, `Dátum`, `Cikk`) VALUES (NULL, '$name', '$pwd', $angol, $nemet, $francia, '$datum', '$cikk')";
    $query = mysqli_query($conn, $sql);

    if ($query) {
        echo "Success";
    } else {
        echo "Failed: " . mysqli_error($conn);
    }
    
    // Kapcsolat lezárása
    mysqli_close($conn);
}