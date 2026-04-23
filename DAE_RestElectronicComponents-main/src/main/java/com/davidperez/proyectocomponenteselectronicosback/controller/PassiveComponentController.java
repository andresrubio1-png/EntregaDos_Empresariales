package com.davidperez.proyectocomponenteselectronicosback.controller;

import com.davidperez.proyectocomponenteselectronicosback.dto.PassiveComponentRequest;
import com.davidperez.proyectocomponenteselectronicosback.model.PackageType;
import com.davidperez.proyectocomponenteselectronicosback.model.PassiveComponent;
import com.davidperez.proyectocomponenteselectronicosback.service.IPassiveComponentService;
import com.davidperez.proyectocomponenteselectronicosback.service.PassiveComponentService;
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
@RequestMapping("/components/passive")
@CrossOrigin(origins = "*")
@Tag(name = "Passive Components", description = "Gestión de componentes electrónicos pasivos (resistencias, capacitores, inductores, etc.)")
public class PassiveComponentController {

    private final IPassiveComponentService service = PassiveComponentService.getInstance();

    @Operation(summary = "Crear un componente pasivo", description = "Registra un nuevo componente pasivo. El id y createdAt son asignados por el servidor. Se debe enviar un manufacturerId válido.")
    @ApiResponses({
            @ApiResponse(responseCode = "201", description = "Componente creado exitosamente",
                    content = @Content(schema = @Schema(implementation = PassiveComponent.class))),
            @ApiResponse(responseCode = "400", description = "manufacturerId no existe o datos inválidos", content = @Content)
    })
    @PostMapping
    public ResponseEntity<PassiveComponent> create(@RequestBody PassiveComponentRequest request) {
        PassiveComponent created = service.create(request);
        return new ResponseEntity<>(created, HttpStatus.CREATED);
    }

    @Operation(summary = "Listar componentes pasivos", description = "Retorna todos los componentes. Se puede filtrar por packageType o por rango de voltaje (minVoltage + maxVoltage).")
    @ApiResponses({
            @ApiResponse(responseCode = "200", description = "Lista de componentes obtenida exitosamente",
                    content = @Content(schema = @Schema(implementation = PassiveComponent.class)))
    })
    @GetMapping
    public ResponseEntity<List<PassiveComponent>> findAll(
            @Parameter(description = "Filtrar por tipo de encapsulado (SMD, DIP, SIP, QFP, BGA, SOT, TO, AXIAL)")
            @RequestParam(required = false) PackageType packageType,
            @Parameter(description = "Voltaje mínimo para filtrar por rango")
            @RequestParam(required = false) Double minVoltage,
            @Parameter(description = "Voltaje máximo para filtrar por rango")
            @RequestParam(required = false) Double maxVoltage) {

        if (packageType != null) {
            return ResponseEntity.ok(service.findByPackageType(packageType));
        }
        if (minVoltage != null && maxVoltage != null) {
            return ResponseEntity.ok(service.findByVoltageRange(minVoltage, maxVoltage));
        }
        return ResponseEntity.ok(service.findAll());
    }

    @Operation(summary = "Buscar componente por ID", description = "Retorna el componente pasivo que coincide con el ID indicado.")
    @ApiResponses({
            @ApiResponse(responseCode = "200", description = "Componente encontrado",
                    content = @Content(schema = @Schema(implementation = PassiveComponent.class))),
            @ApiResponse(responseCode = "404", description = "Componente no encontrado", content = @Content)
    })
    @GetMapping("/{id}")
    public ResponseEntity<PassiveComponent> findById(
            @Parameter(description = "ID del componente") @PathVariable int id) {
        return service.findById(id)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @Operation(summary = "Actualizar un componente pasivo", description = "Actualiza los datos de un componente existente. El createdAt original se preserva.")
    @ApiResponses({
            @ApiResponse(responseCode = "200", description = "Componente actualizado exitosamente",
                    content = @Content(schema = @Schema(implementation = PassiveComponent.class))),
            @ApiResponse(responseCode = "400", description = "manufacturerId no existe o datos inválidos", content = @Content),
            @ApiResponse(responseCode = "404", description = "Componente no encontrado", content = @Content)
    })
    @PutMapping("/{id}")
    public ResponseEntity<PassiveComponent> update(
            @Parameter(description = "ID del componente a actualizar") @PathVariable int id,
            @RequestBody PassiveComponentRequest request) {
        return service.update(id, request)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @Operation(summary = "Eliminar un componente pasivo", description = "Elimina el componente con el ID indicado.")
    @ApiResponses({
            @ApiResponse(responseCode = "204", description = "Componente eliminado exitosamente", content = @Content),
            @ApiResponse(responseCode = "404", description = "Componente no encontrado", content = @Content)
    })
    @DeleteMapping("/{id}")
    public ResponseEntity<Void> delete(
            @Parameter(description = "ID del componente a eliminar") @PathVariable int id) {
        if (service.delete(id)) {
            return ResponseEntity.noContent().build();
        }
        return ResponseEntity.notFound().build();
    }
}
