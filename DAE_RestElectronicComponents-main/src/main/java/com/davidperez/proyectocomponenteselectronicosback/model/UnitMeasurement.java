package com.davidperez.proyectocomponenteselectronicosback.model;

import io.swagger.v3.oas.annotations.media.Schema;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
@AllArgsConstructor
@Schema(description = "Valor nominal del componente con su unidad de medida")
public class UnitMeasurement {

    @Schema(description = "Valor numérico de la magnitud", example = "100.0")
    private double value;

    @Schema(description = "Unidad de medida (Ohm, kOhm, uF, nF, uH, etc.)", example = "Ohm")
    private String unit;
}
