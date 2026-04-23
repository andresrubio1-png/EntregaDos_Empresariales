package com.davidperez.proyectocomponenteselectronicosback.controller;

import com.davidperez.proyectocomponenteselectronicosback.dto.ManufacturerRequest;
import com.davidperez.proyectocomponenteselectronicosback.model.Manufacturer;
import com.davidperez.proyectocomponenteselectronicosback.service.IManufacturerService;
import com.davidperez.proyectocomponenteselectronicosback.service.ManufacturerService;
import io.swagger.v3.oas.annotations.Operation;
import io.swagger.v3.oas.annotations.Parameter;
import io.swagger.v3.oas.annotations.media.Content;
import io.swagger.v3.oas.annotations.media.Schema;
import io.swagger.v3.oas.annotations.responses.ApiResponse;
import io.swagger.v3.oas.annotations.responses.ApiResponses;
import io.swagger.v3.oas.annotations.tags.Tag;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/manufacturers")
@CrossOrigin(origins = "*")
@Tag(name = "Manufacturers", description = "Gestión de fabricantes de componentes electrónicos")
public class ManufacturerController {

    private final IManufacturerService service = ManufacturerService.getInstance();

    @Operation(summary = "Crear un fabricante", description = "Registra un nuevo fabricante. El id y createdAt son asignados automáticamente por el servidor.")
    @ApiResponses({
            @ApiResponse(responseCode = "201", description = "Fabricante creado exitosamente",
                    content = @Content(schema = @Schema(implementation = Manufacturer.class))),
            @ApiResponse(responseCode = "400", description = "Datos de entrada inválidos", content = @Content)
    })
    @PostMapping
    public ResponseEntity<Manufacturer> create(@RequestBody ManufacturerRequest request) {
        return new ResponseEntity<>(service.create(request), HttpStatus.CREATED);
    }

    @Operation(summary = "Listar fabricantes", description = "Retorna todos los fabricantes. Se puede filtrar por país usando el query param 'country'.")
    @ApiResponses({
            @ApiResponse(responseCode = "200", description = "Lista de fabricantes obtenida exitosamente",
                    content = @Content(schema = @Schema(implementation = Manufacturer.class)))
    })
    @GetMapping
    public ResponseEntity<List<Manufacturer>> findAll(
            @Parameter(description = "Filtrar por país (ej: USA, Japan)") @RequestParam(required = false) String country) {
        if (country != null) {
            return ResponseEntity.ok(service.findByCountry(country));
        }
        return ResponseEntity.ok(service.findAll());
    }

    @Operation(summary = "Buscar fabricante por ID", description = "Retorna el fabricante que coincide con el ID indicado.")
    @ApiResponses({
            @ApiResponse(responseCode = "200", description = "Fabricante encontrado",
                    content = @Content(schema = @Schema(implementation = Manufacturer.class))),
            @ApiResponse(responseCode = "404", description = "Fabricante no encontrado", content = @Content)
    })
    @GetMapping("/{id}")
    public ResponseEntity<Manufacturer> findById(
            @Parameter(description = "ID del fabricante") @PathVariable int id) {
        return service.findById(id)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @Operation(summary = "Actualizar un fabricante", description = "Actualiza los datos de un fabricante existente. El createdAt original se preserva.")
    @ApiResponses({
            @ApiResponse(responseCode = "200", description = "Fabricante actualizado exitosamente",
                    content = @Content(schema = @Schema(implementation = Manufacturer.class))),
            @ApiResponse(responseCode = "404", description = "Fabricante no encontrado", content = @Content)
    })
    @PutMapping("/{id}")
    public ResponseEntity<Manufacturer> update(
            @Parameter(description = "ID del fabricante a actualizar") @PathVariable int id,
            @RequestBody ManufacturerRequest request) {
        return service.update(id, request)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @Operation(summary = "Eliminar un fabricante", description = "Elimina el fabricante con el ID indicado.")
    @ApiResponses({
            @ApiResponse(responseCode = "204", description = "Fabricante eliminado exitosamente", content = @Content),
            @ApiResponse(responseCode = "404", description = "Fabricante no encontrado", content = @Content)
    })
    @DeleteMapping("/{id}")
    public ResponseEntity<Void> delete(
            @Parameter(description = "ID del fabricante a eliminar") @PathVariable int id) {
        if (service.delete(id)) {
            return ResponseEntity.noContent().build();
        }
        return ResponseEntity.notFound().build();
    }
}
