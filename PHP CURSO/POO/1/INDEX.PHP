<?php

class User {

    public $type;
}

class Admin {

    public function greet ()
    {
        return "Hola administrador";
    }
}


$user = new User;

$user->type=new Admin;

echo $user->type->greet();
echo "<br>";


include 'gree.php';

echo greet('andres','salcedo');
