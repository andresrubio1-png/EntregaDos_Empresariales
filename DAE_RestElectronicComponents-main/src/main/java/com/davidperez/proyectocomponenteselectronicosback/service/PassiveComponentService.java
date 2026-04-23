package com.davidperez.proyectocomponenteselectronicosback.service;

import com.davidperez.proyectocomponenteselectronicosback.dto.PassiveComponentRequest;
import com.davidperez.proyectocomponenteselectronicosback.model.Manufacturer;
import com.davidperez.proyectocomponenteselectronicosback.model.PackageType;
import com.davidperez.proyectocomponenteselectronicosback.model.PassiveComponent;
import org.springframework.http.HttpStatus;
import org.springframework.web.server.ResponseStatusException;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;
import java.util.concurrent.atomic.AtomicInteger;

public class PassiveComponentService implements IPassiveComponentService {

    private static PassiveComponentService instance;

    private final List<PassiveComponent> components = new ArrayList<>();
    private final AtomicInteger idCounter = new AtomicInteger(1);
    private final IManufacturerService manufacturerService = ManufacturerService.getInstance();

    private PassiveComponentService() {}

    public static synchronized PassiveComponentService getInstance() {
        if (instance == null) {
            instance = new PassiveComponentService();
        }
        return instance;
    }

    private Manufacturer resolveManufacturer(int manufacturerId) {
        return manufacturerService.findById(manufacturerId)
                .orElseThrow(() -> new ResponseStatusException(
                        HttpStatus.BAD_REQUEST,
                        "Manufacturer with id " + manufacturerId + " not found"));
    }

    @Override
    public PassiveComponent create(PassiveComponentRequest request) {
        Manufacturer manufacturer = resolveManufacturer(request.getManufacturerId());
        PassiveComponent component = new PassiveComponent(
                idCounter.getAndIncrement(),
                request.getPinCount(),
                request.getPackageType(),
                request.getVoltage(),
                LocalDateTime.now(),
                manufacturer,
                request.getTolerance(),
                request.getNominalValue()
        );
        components.add(component);
        return component;
    }

    @Override
    public List<PassiveComponent> findAll() {
        return new ArrayList<>(components);
    }

    @Override
    public Optional<PassiveComponent> findById(int id) {
        return components.stream()
                .filter(c -> c.getId() != null && c.getId() == id)
                .findFirst();
    }

    @Override
    public List<PassiveComponent> findByPackageType(PackageType packageType) {
        return components.stream()
                .filter(c -> packageType.equals(c.getPackageType()))
                .toList();
    }

    @Override
    public List<PassiveComponent> findByVoltageRange(double minVoltage, double maxVoltage) {
        return components.stream()
                .filter(c -> c.getVoltage() >= minVoltage && c.getVoltage() <= maxVoltage)
                .toList();
    }

    @Override
    public Optional<PassiveComponent> update(int id, PassiveComponentRequest request) {
        return findById(id).map(existing -> {
            Manufacturer manufacturer = resolveManufacturer(request.getManufacturerId());
            existing.setPinCount(request.getPinCount());
            existing.setPackageType(request.getPackageType());
            existing.setVoltage(request.getVoltage());
            existing.setTolerance(request.getTolerance());
            existing.setNominalValue(request.getNominalValue());
            existing.setManufacturer(manufacturer);
            return existing;
        });
    }

    @Override
    public boolean delete(int id) {
        return components.removeIf(c -> c.getId() != null && c.getId() == id);
    }
}
