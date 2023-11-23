# BackEndApi
Backend prueba RedBrow

El proyecto fue hecho en VisualStudio 2022, dentro de los archivos se encuentran 2 que son de extencion .SQL, la cual son para crear la base de datos y las 
tablas que contine la base dedatos.

Una vez creadas la base de datos y las tablas, pueden ejecutar el proyecto en Visual Studio 2022 y se ejecutara automaticamente, desplegara swagger para que 
puedan probar los endpoint.

De igual manera desarrolle la autenticacion JWT, para que funcione se debe descomentar en el controlador de usuario el decorador [Autorize], se dejo desactivado
por que en el front no alcance hacer para la validacion con JWT.

VISUAL CODE, si desea correrlo en VS Code, solo es abrir la carpeta, habilitar una terminal y desde donde estan todos los archivos ejecutar "dotnet run", se ejecutara 
el proyecto pero no desplegara la pagina swagger, al menos que se lo indique, pero el proyecto queda en escucha.

