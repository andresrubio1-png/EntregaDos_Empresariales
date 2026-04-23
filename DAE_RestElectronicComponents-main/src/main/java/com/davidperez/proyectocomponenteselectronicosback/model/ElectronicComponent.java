package com.davidperez.proyectocomponenteselectronicosback.model;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.time.LocalDateTime;

@Data
@NoArgsConstructor
@AllArgsConstructor
public abstract class ElectronicComponent {
    private Integer id;
    private int pinCount;
    private PackageType packageType;
    private double voltage;
    private LocalDateTime createdAt;
    private Manufacturer manufacturer;

    @Override
    public String toString() {
        return "ElectronicComponent{" +
                "id=" + id +
                ", pinCount=" + pinCount +
                ", packageType='" + packageType + '\'' +
                ", voltage=" + voltage +
                ", createdAt=" + createdAt +
                '}';
    }
}
