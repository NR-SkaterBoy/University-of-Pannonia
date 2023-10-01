<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tutorial</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <form action="connect.php" method="post">
        <label for="name">Name</label><br>
        <input type="text" name="name" id="name" required><br>
        <label for="pwd">Password:</label><br>
        <input type="password" name="pwd" id="pwd" required><br>
        <input type="date" name="date" id="date"> <br>
        <input type="checkbox" name="angol" id="angol">Angol
        <input type="checkbox" name="nemet" id="nemet">Német
        <input type="checkbox" name="francia" id="francia">Francia<br>
        <textarea name="cikk" id="cikk" cols="30" rows="10"></textarea>

        <input type="submit" value="Küldés" name="submit">
        <input type="submit" value="Mégse" name="cancel">
    </form>
    
</body>
</html>