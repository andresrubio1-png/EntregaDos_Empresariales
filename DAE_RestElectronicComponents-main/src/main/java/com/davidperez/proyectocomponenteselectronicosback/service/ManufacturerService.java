package com.davidperez.proyectocomponenteselectronicosback.service;

import com.davidperez.proyectocomponenteselectronicosback.dto.ManufacturerRequest;
import com.davidperez.proyectocomponenteselectronicosback.model.Manufacturer;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;
import java.util.concurrent.atomic.AtomicInteger;

public class ManufacturerService implements IManufacturerService {

    private static ManufacturerService instance;

    private final List<Manufacturer> manufacturers = new ArrayList<>();
    private final AtomicInteger idCounter = new AtomicInteger(1);

    private ManufacturerService() {}

    public static synchronized ManufacturerService getInstance() {
        if (instance == null) {
            instance = new ManufacturerService();
        }
        return instance;
    }

    @Override
    public Manufacturer create(ManufacturerRequest request) {
        Manufacturer manufacturer = new Manufacturer(
                idCounter.getAndIncrement(),
                request.getName(),
                request.getCountry(),
                LocalDateTime.now(),
                request.getAverageLeadTime()
        );
        manufacturers.add(manufacturer);
        return manufacturer;
    }

    @Override
    public List<Manufacturer> findAll() {
        return new ArrayList<>(manufacturers);
    }

    @Override
    public Optional<Manufacturer> findById(int id) {
        return manufacturers.stream()
                .filter(m -> m.getId() != null && m.getId() == id)
                .findFirst();
    }

    @Override
    public Optional<Manufacturer> findByName(String name) {
        return manufacturers.stream()
                .filter(m -> m.getName() != null && m.getName().equalsIgnoreCase(name))
                .findFirst();
    }

    @Override
    public List<Manufacturer> findByCountry(String country) {
        return manufacturers.stream()
                .filter(m -> m.getCountry() != null && m.getCountry().equalsIgnoreCase(country))
                .toList();
    }

    @Override
    public Optional<Manufacturer> update(int id, ManufacturerRequest request) {
        return findById(id).map(existing -> {
            existing.setName(request.getName());
            existing.setCountry(request.getCountry());
            existing.setAverageLeadTime(request.getAverageLeadTime());
            return existing;
        });
    }

    @Override
    public boolean delete(int id) {
        return manufacturers.removeIf(m -> m.getId() != null && m.getId() == id);
    }
}
