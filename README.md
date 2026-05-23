# Actividad #10  – Práctica .NET: Crear solución multi-proyecto

## Datos académicos
- **Institución**: Tecnológico de Software
- **Materia:** Arquitectura de Software
- **Profesor:** Jorge Javier Pedrozo Romero
- **Actividad 10**
- **Estudiante:** Giovana Ruby Díaz Anduze
- *Finalizado el 22 de mayo de 2026*

---

## CatalogoApp: GAMEVAULT

Una actualización de la actividad realizada en la semana 1 de un catálogo de videojuegos: GAMEVAULT, la cual ahora implementamos los conceptos vistos en la materia siguiendo una arquitectura en capas basada en principios de separación de responsabilidades.

El proyecto permite la administración de un catálogo de elementos mediante una estructura organizada en **Domain**, **Application**, **Infrastructure** y **Presentation**.

---

## Estructura del proyecto

```bash
CatalogoApp
│
├── Catalogo.Application     # Casos de uso y servicios 
├── Catalogo.Domain          # Entidades y lógica de dominio
├── Catalogo.Infrastructure  # Persistencia y acceso a datos
├── Catalogo.Presentation    # Interfaz de usuario / consola
```

---

## Tecnologías implementadas

- C#
- .NET
- Programación Orientada a Objetos
- Arquitectura por capas
- Principios SOLID

---

## ¿Cómo ejecutar el proyecto?

1. Clonar el repositorio:

```bash
git clone <URL_DEL_REPOSITORIO>
```

2. Entrar a la carpeta del proyecto:

```bash
cd CatalogoApp
```

3. Restaurar dependencias:

```bash
dotnet restore
```

4. Compilar el proyecto:

```bash
dotnet build
```

5. Ejecutar la aplicación:

```bash
dotnet run --project Catalogo.Presentation
```

---

## Capturas de pantalla

### Pantalla de inicio

<img width="2560" height="1600" alt="1" src="https://github.com/user-attachments/assets/33cb3166-17fe-4182-9742-b2c53a8b2afc" />

<img width="2560" height="1600" alt="2" src="https://github.com/user-attachments/assets/e04cfe3f-23ed-4d83-90bc-0cc27a757849" />

### Catálogo de Videojuegos

<img width="2542" height="1338" alt="3" src="https://github.com/user-attachments/assets/080b592e-27a3-4c30-b4f5-e8d887e22650" />

### Agregar videojuego

<img width="2548" height="1338" alt="4" src="https://github.com/user-attachments/assets/0dc83f7e-dd48-4934-a37d-7ccab76776fc" />

### Reseñas con usuarios creados

<img width="2534" height="1328" alt="5" src="https://github.com/user-attachments/assets/0600e041-05a2-4e69-86ba-f3076724265e" />

<img width="2544" height="1342" alt="6" src="https://github.com/user-attachments/assets/1d02f939-6b8c-4f17-bd5c-8202e4c3103e" />

### Inicio de sesión

<img width="2550" height="1342" alt="7" src="https://github.com/user-attachments/assets/8885b1bf-358f-4545-9909-dc747dbbb5bf" />

---

## Cláusula de IA

Yo, Giovana Ruby Díaz Anduze, aclaro que utilicé la inteligencia artificial **Claude** para correcciones de bugs y ayuda en el diseño de la página.
