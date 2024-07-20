# VR Escape Room - Jigsaw Theme

## Descripción del Proyecto

Este proyecto es una sala de escape en realidad virtual (VR) inspirada en la temática de Jigsaw. Los jugadores deben resolver una serie de acertijos y desafíos para escapar de la habitación. La sala incluye un código numérico en el techo que abre una caja fuerte, un mensaje de audio que deletrea 'DEATH', un tablero con letras subrayadas, y cinco cubos de colores.

## Características

- **Código Numérico en el Techo:** Los jugadores deben encontrar y usar este código para abrir una caja fuerte.
- **Mensaje de Audio:** Un mensaje de audio reproduce la palabra 'DEATH', la cual es clave para resolver uno de los acertijos.
- **Tablero con Letras Subrayadas:** Las letras subrayadas en el tablero forman pistas importantes.
- **Cubos de Colores:** Cinco cubos de diferentes colores que los jugadores deben usar en uno de los desafíos.
- **Escenas:**
  - `FinalMenu`
  - `ScapeRoom`
  - `GameOver`

## Tecnologías Utilizadas

- **Unity:** Motor de desarrollo de videojuegos utilizado para crear el entorno VR.
- **Meta XR Interaction SDK:** SDK utilizado para integrar las interacciones de VR.
- **C#:** Lenguaje de programación utilizado para los scripts y la lógica del juego.

## Instalación y Configuración

1. **Clonar el Repositorio:**
   ```bash
   git clone https://github.com/rominaromani/Scape-Room-VR.git
   cd escape-room-vr
   ```

2. **Abrir el Proyecto en Unity:**
   - Asegúrate de tener Unity instalado (versión recomendada: 2022.3.31f1).
   - Abre Unity Hub y añade el proyecto clonado.

3. **Instalar Dependencias:**
   - Abre el proyecto en Unity.
   - Navega a la ventana de Package Manager (`Window > Package Manager`).
   - Instala el paquete `XR Meta SDK All-in-One`.
   - Asegúrate de que todas las demás dependencias necesarias estén instaladas.

4. **Configurar el Entorno de Desarrollo:**
   - Configura los ajustes de VR en Unity (`Edit > Project Settings > XR Plugin Management`).
   - Activa el plugin de VR correspondiente a tu dispositivo (Oculus, OpenXR, etc.).

5. **Configurar para Android:**
   - Cambia la plataforma a Android (`File > Build Settings`, selecciona Android y haz clic en `Switch Platform`).
   - En `Player Settings`:
     - **Color Space:** Configura en `Linear`.
     - **Auto Graphics API:** Desactiva esta opción.
     - **Graphics API:** Deja solo `OpenGLES3`.
     - **Minimum API Level:** Configura en `API Level 29`.
     - **Scripting Backend:** Configura en `IL2CPP`.
     - **Target Architectures:** Activa solo `ARM64`.

   - Si ocurre un error al compilar, ve a `Project Settings > Meta XR` y haz clic en `Apply All`.
