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


## ✨ Funcionalidades

- Gestión de elementos del catálogo
- Organización modular del código
- Separación de responsabilidades
- Estructura escalable y mantenible
- Implementación de servicios y entidades

---

## Cómo ejecutar el proyecto

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
