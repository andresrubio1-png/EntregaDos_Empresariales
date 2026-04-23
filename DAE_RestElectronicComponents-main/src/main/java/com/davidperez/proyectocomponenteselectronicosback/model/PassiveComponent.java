package com.davidperez.proyectocomponenteselectronicosback.model;

import lombok.Data;
import lombok.EqualsAndHashCode;
import lombok.NoArgsConstructor;

import java.time.LocalDateTime;

@Data
@NoArgsConstructor
@EqualsAndHashCode(callSuper = true)
public class PassiveComponent extends ElectronicComponent {
    private double tolerance;
    private UnitMeasurement nominalValue;

    public PassiveComponent(int id, int pinCount, PackageType packageType, double voltage,
                            LocalDateTime createdAt, Manufacturer manufacturer,
                            double tolerance, UnitMeasurement nominalValue) {
        super(id, pinCount, packageType, voltage, createdAt, manufacturer);
        this.tolerance = tolerance;
        this.nominalValue = nominalValue;
    }
}
