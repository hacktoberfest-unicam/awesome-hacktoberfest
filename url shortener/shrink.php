<?php
    if(!isset($_POST['link']) || empty($_POST['link'])){
    	header("LOCATION: index.php");
        exit(0);
    }
    function make_short(){
        $conn = new PDO("mysql:host=localhost;dbname=my_urlshorteningunicam", "root", "");
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    	$caratteri = '0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ';
        do{
          $tmp=substr(str_shuffle($caratteri), 0, 8);
          $x=$conn->prepare("SELECT `short` FROM `assoc` WHERE `short`=?");
          $x->execute(array($tmp));
        }while($x->rowCount()>0);
        return $tmp;
    }
    $link=$_POST['link'];
    session_start();
    if(filter_var($link, FILTER_VALIDATE_URL)){
    	$conn = new PDO("mysql:host=localhost;dbname=my_urlshorteningunicam", "root", "");
    	$conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        $sql=$conn->prepare("INSERT INTO `assoc`(`urlOrig`, `short`) VALUES (?,?)");
        $short=make_short();
        $sql->execute(array($link, $short));
        $_SESSION['val']="Link rimpicciolito: http://urlshorteningunicam.altervista.org/index.php?q=".$short;
    }else{
    	$_SESSION['val']="Inserisci un URL valida";
    }
    header("LOCATION:index.php");
?>