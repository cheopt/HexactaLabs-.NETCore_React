# HexactaLabs-.NETCore_React

Hexacta 2020

Bienvenidos a los Hexacta Labs

Este curso está orientado a profesionales, no profesionales y recién iniciados en el desarrollo web. 
Se trata de la implementación guiada de un sitio web sobre el manejo de stock de productos generales.

El curso tiene diferentes etapas y nivelaciones con este formato:
* __Initial__: Presentación de la aplicación básica, pasos para correrla localmente y planteo de la primer actividad: Backend con .NetCore.
* __Level 1__: Se nivelará presentando una aplicación con las actividades de la etapa inicial completas. Planteo de la segunda actividad: Frontend con ReactJS.
* __Level 2__: Se presenta la aplicación con las actividades anteriores completas. Planteo de la tercera actividad: FullStack development.
* __Final__: Se presenta la aplicación completa. Planteo de la actividad final. 

## Requisitos
* Conocimientos básicos de HTML
* Manejo básico de bases de datos
* Conocimientos básicos sobre ORMs

## [Documentación](./Docs/index.md)


# Actividad Inicial
Para el trabajo inicial, se necesita crear un servicio backend que se conecte a la base de datos local para obtener información y brindar operaciones CRUD de la entidad __Provider__.
El sistema debe ser capaz de:
* Crear, editar y eliminar un nuevo provider a través de la sección Proveedores dentro del sitio.
* Realizar búsquedas de proveedores.
* La interfaz swagger debe mostrar todos los servicios expuestos.
* La web React debe conectarse con estos servicio configurando un store.

# Tips
## Front end

Para correr la app, solo hace falta estar situado en la carpeta `Stock.Web/client-app` y ejecutar `npm start` en la consola.

Los request a la API se hacen a través del server de desarrollo que usa create-react-app, el cual se configura en el archivo
`package.json` bajo la key `proxy`. Por defecto, se espera que la API corra en `localhost:5000`.

## Backend

```dotnet run --project Stock.Api/Stock.Api.csproj


Posibles problemas: 
para crear los assets para buildear: 
ctrl+alt+p => Net generate assets

Si vscode no les carga c# y les muestra un error de: 

se resuelve con este issue: 
https://stackoverflow.com/questions/55535177/omnisharp-msbuild-projectmanager-attempted-to-update-project-that-is-not-loaded

The SDK 'Microsoft.NET.Sdk.Web' specified could not be found.
https://github.com/OmniSharp/omnisharp-roslyn/issues/1313#issuecomment-429039879
```

