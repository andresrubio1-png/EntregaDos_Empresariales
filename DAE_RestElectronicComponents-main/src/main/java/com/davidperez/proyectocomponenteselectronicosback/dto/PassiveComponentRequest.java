package com.davidperez.proyectocomponenteselectronicosback.dto;

import com.davidperez.proyectocomponenteselectronicosback.model.PackageType;
import com.davidperez.proyectocomponenteselectronicosback.model.UnitMeasurement;
import io.swagger.v3.oas.annotations.media.Schema;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
@Schema(description = "Datos requeridos para crear o actualizar un componente pasivo")
public class PassiveComponentRequest {

    @Schema(description = "Número de pines del componente", example = "2", requiredMode = Schema.RequiredMode.REQUIRED)
    private int pinCount;

    @Schema(description = "Tipo de encapsulado físico del componente", example = "SMD", requiredMode = Schema.RequiredMode.REQUIRED)
    private PackageType packageType;

    @Schema(description = "Voltaje de operación en voltios", example = "5.0", requiredMode = Schema.RequiredMode.REQUIRED)
    private double voltage;

    @Schema(description = "ID del fabricante al que pertenece este componente", example = "1", requiredMode = Schema.RequiredMode.REQUIRED)
    private int manufacturerId;

    @Schema(description = "Tolerancia del componente (ej: 0.05 = 5%)", example = "0.05", requiredMode = Schema.RequiredMode.REQUIRED)
    private double tolerance;

    @Schema(description = "Valor nominal del componente con su unidad", requiredMode = Schema.RequiredMode.REQUIRED)
    private UnitMeasurement nominalValue;
}
