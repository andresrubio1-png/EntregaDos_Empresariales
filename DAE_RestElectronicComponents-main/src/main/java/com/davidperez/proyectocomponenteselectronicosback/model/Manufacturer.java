package com.davidperez.proyectocomponenteselectronicosback.model;

import io.swagger.v3.oas.annotations.media.Schema;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.time.LocalDateTime;

@Data
@NoArgsConstructor
@AllArgsConstructor
@Schema(description = "Fabricante de componentes electrónicos")
public class Manufacturer {

    @Schema(description = "Identificador único del fabricante", example = "1", accessMode = Schema.AccessMode.READ_ONLY)
    private Integer id;

    @Schema(description = "Nombre del fabricante", example = "Texas Instruments")
    private String name;

    @Schema(description = "País de origen del fabricante", example = "USA")
    private String country;

    @Schema(description = "Fecha y hora de registro del fabricante", accessMode = Schema.AccessMode.READ_ONLY)
    private LocalDateTime createdAt;

    @Schema(description = "Tiempo promedio de entrega en días", example = "14.5")
    private double averageLeadTime;
}
