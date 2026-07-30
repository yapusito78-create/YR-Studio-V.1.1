# Analizador Básico - YR Studio V.1.1
## Objetivo
El Analizador Básico es el primer módulo de análisis de archivos multimedia. Su función es obtener información rápida del archivo sin realizar análisis pesados. Debe entregar los datos obtenidos al Router sin conocer qué módulo los utilizará después.
## Principio de funcionamiento
El Analizador Básico funciona como una caja cerrada. Recibe una entrada, procesa la información necesaria y entrega una salida. El módulo no llama a otros módulos. El módulo no accede a Biblioteca. El módulo no decide qué hacer con los datos obtenidos.
## Flujo de datos
Archivo → Analizador Básico → Router → Otros módulos.
El Analizador Básico solamente analiza y entrega información. La comunicación entre módulos es responsabilidad del Router.
## Entrada
El módulo recibe como entrada la ruta del archivo multimedia.
Ejemplo:
D:\Musica\Tema.mp3
## Proceso interno
El Analizador Básico obtiene la información disponible del archivo utilizando métodos rápidos de lectura. No realiza procesos pesados como análisis de audio avanzado, detección de silencios, LUFS, BPM u otros análisis pertenecientes a módulos posteriores.
## Datos generados
El Analizador Básico puede obtener:
- Nombre del archivo.
- Ruta completa.
- Extensión.
- Tamaño.
- Duración.
- Fecha del archivo.
- Información básica disponible del formato.
## Comunicación con Router
El Analizador Básico entrega datos crudos al Router. No adapta formatos para otros módulos.
Ejemplo:
El Analizador Básico entrega:
Duración = 1234.56 segundos
El Router recibe ese dato y decide qué hacer con él.
## Transformación de datos
Las conversiones de formato pertenecen exclusivamente al Router.
Ejemplo:
Módulo A entrega:
1.23456
Router recibe:
1.23456
Módulo B necesita:
12:34:56
El Router transforma:
1.23456 → 12:34:56
El Router envía:
12:34:56
Si otro módulo necesita nuevamente:
1.23456
El Router envía el dato original sin modificaciones.
Los módulos nunca se adaptan entre ellos. El Router es el encargado de convertir formatos cuando sea necesario.
## Dependencias
Permitido:
- Librerías necesarias para leer información básica de archivos multimedia.
No permitido:
- Biblioteca.
- Playlist.
- Analizador Intermedio.
- Analizador Profundo.
- Otros módulos de YR Studio.
## Eventos
El Analizador Básico informa progreso del proceso mediante eventos.
Ejemplo:
0% Inicio.
25% Lectura de archivo.
50% Obtención de información.
75% Procesamiento.
100% Finalizado.
El Router recibe estos eventos y decide cómo distribuirlos.
## Arquitectura
El Analizador Básico no conoce el flujo completo del sistema. Solamente conoce:
Entrada → Análisis → Salida.
El Router conoce:
Origen del dato → Transformación necesaria → Destino del dato.
## Estado
Proyecto: YR Studio V.1.1
Módulo: Analizador Básico
Estado: En desarrollo y revisión.