package com.davidperez.proyectocomponenteselectronicosback.dto;

import io.swagger.v3.oas.annotations.media.Schema;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
@Schema(description = "Datos requeridos para crear o actualizar un fabricante")
public class ManufacturerRequest {

    @Schema(description = "Nombre del fabricante", example = "Texas Instruments", requiredMode = Schema.RequiredMode.REQUIRED)
    private String name;

    @Schema(description = "País de origen del fabricante", example = "USA", requiredMode = Schema.RequiredMode.REQUIRED)
    private String country;

    @Schema(description = "Tiempo promedio de entrega en días", example = "14.5", requiredMode = Schema.RequiredMode.REQUIRED)
    private double averageLeadTime;
}
