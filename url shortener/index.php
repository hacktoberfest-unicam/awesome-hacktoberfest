<?php 
    if(isset($_GET['q'])){
    	$conn = new PDO("mysql:host=localhost;dbname=my_urlshorteningunicam", "root", "");
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        $sql=$conn->prepare("SELECT `urlOrig` FROM `assoc` WHERE `short`=:val");
        $q=$_GET['q'];
        $sql->bindParam(":val",$_GET['q']);
        $sql->execute();
        header("LOCATION: ".$sql->fetch(PDO::FETCH_ASSOC)['urlOrig']);
        exit(0);
    }else{
    	session_start();
    	?>
        <form method="post" action="shrink.php">
        	<p>Inserisci URL:</p>
            <input type="url" name="link"/>
            <input type="submit" value="Shrink">
        </form>
        <p><?php 
        if(isset($_SESSION['val'])){
        	echo $_SESSION['val'];
        } ?></p>
        <?php
    }
?>