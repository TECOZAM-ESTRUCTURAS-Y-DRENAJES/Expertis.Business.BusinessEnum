Imports Solmicro.Expertis.Engine

Public Structure udtCambioDeEstadoActivo
    Dim DtSerie As DataTable
    Dim udtActivo As DataTable
    Dim udtHistorico As DataTable
End Structure

Public Structure udtDtStock
    Dim blnGestionStock As Boolean
    Dim blnGestionPorLotes As Boolean
    Dim blnGestionNSerie As Boolean
    Dim lngResultado As Integer
    Dim lngIdLineaMov As Integer
    Dim dblStock As Double
    Dim strIDGenerico As String
    Dim DtArtAlm As DataTable
    Dim DtDesglose As DataTable
    Dim DtHistMov As DataTable
    Dim DtLog As DataTable
    Dim DtAux As DataTable
End Structure

Public Structure udtRcsMateriales
    Dim DtOrdenEstructura As DataTable
    Dim DtOFControlEstructura As DataTable
    Dim udtStockCarrier As DataTable
End Structure

Public Structure udtRcsProductoTerminado
    Dim DtOFControlEstructura As DataTable
    Dim udtStockCarrier As DataTable
End Structure

Public Structure udtRcsProduccion
    Dim DtOrdenFabricacion As DataTable
    Dim DtOFControl As DataTable
    Dim DtOrdenRuta As DataTable
    Dim DtOrdenEstructura As DataTable
    Dim udtMateriales As udtRcsMateriales
    Dim udtProductoTerminado As udtRcsProductoTerminado
End Structure

<Serializable()> _
Public Structure udtDatosTransporteVenta
    Dim IDProveedor As String
    Dim IDProvincia As String
    Dim IDTipoCamion As String
    Dim FechaPrevista As Date
    Dim Precio As Double
    Dim HoraSalida As Date
    Dim HoraLlegada As Date
    Dim Conductor As String
End Structure

Public Enum enumTipoCodigo
    Articulo = 0
    Cliente = 1
    EfectosCliente = 2
    EfectosGestionCobros = 3
    Anticipos = 4
    Proveedor = 5
    EfectosProveedor = 12
    BancoPropio = 6
    ClienteGrupo = 7
    ProveedorGrupo = 8
    Acreedor = 9
    InmovilizadoCortoPlazo = 10
    InmovilizadoLargoPlazo = 11
    EfectosCartera = 13
End Enum

Public Enum enumSiNo
    No = 0
    Si = 1
End Enum

Public Enum enumBoolean
    No = 0
    Si = 1
    Todos = 2
End Enum

Public Enum enumfvcEstado
    fvcNoContabilizado = 0
    fvcContabilizado = 1
End Enum

Public Enum enumfvcFechaAlbaran
    fvcUltima = 0
    fvcPrimera = 1
End Enum

Public Enum enumCuenta
    cAuxiliar = 0
    cNoExisteEnPlan = 1
    cNoAuxiliar = 2
    cVacia = 3
End Enum

Public Enum enumfvcTipoFactura
    fvcNormal = 0
    fvcAnticipo = 1
    fvcFinal = 2
End Enum

Public Enum enumaccEstado
    accNoFacturado = 0
    accParcFacturado = 1
    accFacturado = 2
    'David Velasco
    accTodas = 3
End Enum

Public Enum enumCriteriosCalidad
    ccCorrectoIncorrecto = 0
    CCCantidad = 1
    ccCantidadPorcentaje = 2
    CCFechas = 3
    ccControlCalidad = 4
    ccReactividad = 5
End Enum

Public Enum enumaclEstadoStock
    aclNoActualizado = 0
    aclActualizado = 1
    aclSinGestion = 2
End Enum

Public Enum enumaclEstadoFactura
    aclNoFacturado = 0
    aclFacturado = 2
    aclParcFacturado = 1
End Enum

Public Enum enumaclEstadoFacturaAuxiliar
    aclauxNoFacturado = 0
    aclauxFacturado = 1
    aclauxParcFacturado = 2
End Enum

Public Enum enumaclTipoLineaAlbaran
    aclNormal = 0
    aclKit = 1
    aclComponente = 2
    aclSubcontratacion = 3
    aclRealquiler = 4
End Enum

Public Enum enumavcEstadoFactura
    avcNoFacturado = 0
    avcParcFacturado = 1
    avcFacturado = 2
    avcNoFacturable = 3
End Enum

Public Enum enumAsignacionAnaliticaA 'Enumerado para saber si la Asignacion Analitica es por Artículo por por CContable
    aaArticulo = 1
    aaCContable = 2
End Enum

Public Enum enumavlEstadoStock
    avlNoActualizado = 0
    avlActualizado = 1
    avlSinGestion = 2
End Enum

Public Enum enumavlEstadoFactura
    avlNoFacturado = 0
    avlParcFacturado = 1
    avlFacturado = 2
End Enum

Public Enum enumavlTipoLineaAlbaran
    avlNormal = 0
    avlKit = 1
    avlComponente = 2
    avlFantasma = 3
End Enum

Public Enum enumTipoPresup
    PorCuenta = 0
    PorCentro = 1
    PorAgrupacion = 2
End Enum

Public Enum RecupAlmAlquiler
    reAlmacenArticulo = 0
    reAlmacenCentroGestion = 1
End Enum

Public Enum enumArtTasaResiduos
    artGestionObra = 0
    artFacturar = 1
    artNoFacturar = 2
End Enum

Public Enum enumTipoFacturacionAlquiler
    enumTFASinAlquiler = 0
    enumTFADiasNaturales = 1
    enumTFADiasLaborables = 2
    enumTFAMeses = 3
    enumTFAMesesDiasLaborables = 4
    enumTFAContador = 5
End Enum

Public Enum enumPrecioEstandar
    enumPSPorcEstandar = 0
    enumPSPorcUltimo = 1
    enumPSUltimo = 2
    enumPSIndividual = 3
End Enum

Public Enum enumPrecioProv
    enumPPPorcPrecio = 0
    enumPPDto1 = 1
    enumPPDto2 = 2
    enumPPDto3 = 3
    enumPPPorcEstandar = 4
    enumPPPorcUltimo = 5
    enumPPEstandar = 6
    enumPPUltimo = 7
    enumPPIndividual = 8
End Enum

Public Enum enumPlazo
    enumPIndividual = 0
    enumPMasivo = 1
    enumPCompra = 2
    enumPFabrica1 = 3
End Enum

Public Enum enumControlRecepcion
    crProcesoCalidad = 0
    crSiempre = 1
    crNunca = 2
End Enum

Public Enum enumaFabricadoComprado
    aComprado = 1
    aFabricados = 0
    aTodos = 2
End Enum

Public Enum enumPuntoPedido
    enumPPIndividual = 0
    enumPPMasivo = 1
    enumPPCompra = 2
    enumPPFabrica = 3
End Enum

Public Enum enumLoteMinimo
    enumLoteIndividual = 0
    enumLoteMasivo = 1
End Enum

Public Enum enumstdUdTiempo
    Dias = 0
    Horas = 1
    Minutos = 2
    Segundos = 3
End Enum

Public Enum enumstdCriterioValoracion
    stdPrecioEstandar = 0
    stdCritValArticulo = 1
End Enum

Public Enum enumacsTipoArticulo
    acsCompra = 0
    acsFabrica = 1
End Enum

Public Enum enumCosteVarios
    cvValor = 0
    cvPorTotal = 1
    cvPorMaterial = 2
    cvPorInterno = 3
    cvPorExterno = 4
    cvPorPVP = 5
End Enum

Public Enum enumcaMesAño
    caEnero = 1
    caFebrero = 2
    caMarzo = 3
    caAbril = 4
    caMayo = 5
    caJunio = 6
    caJulio = 7
    caAgosto = 8
    caSeptiembre = 9
    caOctubre = 10
    caNoviembre = 11
    caDiciembre = 12
End Enum

Public Enum enumTipoAccion
    AsignarCampo = 0
    'AsignarCaracterística = 1
End Enum

Public Enum enumObjetoCampo
    Cantidad = 0
    Merma = 1
End Enum

Public Enum enumObjetoCampoRuta
    CTrabajo = 0
    TEjecucion = 1
    TPreparacion = 2
End Enum

Public Enum enumTipoValorAccion
    ValorFijo = 0
    Formula = 1
End Enum

Public Enum enumETipoValor
    ValorFijo = 0
    Formula = 1
    Caracteristica = 3
End Enum

Public Enum enumTipoDato
    Alfanumerico = 0
    Numerico = 1
End Enum

Public Enum enumTipoValor
    Discreto = 0
    Continuo = 1
End Enum

Public Enum enumTipoCondicionAccion
    Estructura = 0
    Ruta = 1
End Enum

Public Enum enumTipoCaracteristica
    Valor = 0
    Formula = 1
End Enum

Public Enum enumcentroTipoCentro
    centroInterno = 0
    centroExterno = 1
End Enum

Public Enum enumstkResultadoCierre
    stkRCPrecioCeroNegativo = -2
    stkRCStockNegativo = -1
    stkRCError = 0
    stkRCPasoTerminado = 1
End Enum

Public Enum enummcPeriodoFacturacion
    mcDiaria = 0
    mcSemanal = 1
    mcQuincenal = 2
    mcMensual = 3
End Enum

Public Enum enummcTipoFacturacion
    mcGeneral = 0
    mcAutoFacturacion = 1
End Enum

Public Enum enummcAgrupAlbaran
    mcCliente = 0
    mcPedido = 1
End Enum

Public Enum enummcAgrupAlbaranObra
    mcCliente = 0
    mcObra = 1
    mcObraTrabajo = 2
End Enum

Public Enum enummcAgrupOTObra
    mcCliente = 0
    mcObra = 1
    mcOrdenTrabajo = 2
End Enum

Public Enum enummcAgrupFactura
    mcCliente = 0
    mcAlbaran = 1
End Enum

Public Enum enummcAgrupFacturaObra
    mcSinAgrupar = 0
    mcCliente = 1
    mcObra = 2
    mcObraTrabajo = 3
    mcObraPedidoClte = 4
End Enum

Public Enum enummcAgrupPedido
    mcCliente = 0
    mcPrograma = 1
End Enum

Public Enum enumcdTipoDireccion
    cdDireccionEnvio = 0
    cdDireccionFactura = 1
    cdDireccionGiro = 2
End Enum

Public Enum enumCobroContabilizado
    CobroNoContabilizado = 0
    CobroContabilizado = 1
End Enum

Public Enum enumTipoRemesa
    RemesaAlCobro = 0
    RemesaAlDescuento = 1
    RemesaAnticipo = 2
End Enum

Public Enum enumTipoRemesaConsulta
    RemesaAlCobro = 0
    RemesaAlDescuento = 1
    RemesaAnticipo = 2
    Todo = 3
End Enum

Public Enum enumTipoAsientoRemesa
    Banco_a_Cliente = 0
    Banco_a_EfectoDto = 1
    Banco_a_EfectoDto_EfectoClte = 2
End Enum

Public Enum enumCobroSituacion
    NoNegociado = 0
    EnviadoClte = 1
    RecibidoClte = 2
    Negociado = 3
    Vencido = 4
    Cobrado = 5
    Impagado = 6
    Devuelto = 7
    Descontado = 8
    GeneradoPago = 9
    Factoring = 10  '?
    Anticipado = 11
End Enum

Public Enum enumTipoConciliacionBancaria
    Automatico = 0
    Manual = 1
End Enum

Public Enum enumcpPeriodo
    cpDia = 0
    cpSemana = 1
    cpMes = 2
    cpAño = 3
End Enum

'0: Asiento a proveedor con pago NoPagado y NoContabilizado
'1: Asiento a proveedor con pago Pagado y NoContabilizado
'2: Asiento a proveedor sin pago
'3: Asiento a banco sin pago
Public Enum enumTipoAsiento
    taProveedorConPagoNPyNC = 0
    taProveedorConPagoPyNC = 1
    taProveedorSinPago = 2
    taBancoSinPago = 3
End Enum

Public Enum ResultadoADDApuntes
    Ok = -1
    AsientoDescuadrado = 0
    MesCerrado = 1
    CContableSinAnalit = 2
    AnaliticaIncorrecta = 3
    Otros = 4
End Enum

Public Enum enumTipoGeneracionApunte
    Automatico = 0
    NoAutomatico = 1
End Enum

Public Enum enumDiarioTipoApunte
    FactV = 0
    factc = 1
    Cobro = 2
    Pago = 3
    Remesa = 4
    Amortiz = 5
    Manual = 6
    Apertura = 7
    Cierre = 8
    Regularizacion = 9
    CierreIva = 10
    Gasto = 11
    LiquidacionRemesa = 12
    DevolucionRemesa = 13
    BajaElemento = 14
    BajaParcialElemento = 15
    Varios = 16
    Talon = 17
    '''    PagoPeriodico = 18
    PagoConcesion = 19
    Compensacion = 20
    RegularizacionEx = 21
    Revision = 22
    RecalculoCortoPlazo = 23
    Leasing = 24
    Caja = 25
    RemesaPago = 26
    ContabilizacionFianzasAlquiler = 27
    PasoInmaterial = 28
    RegularizacionGrupos8y9 = 29
    'Dotacion = 30      'CUIDADO!! Retencion = 30 '//En Latinoamerica
    Anticipo = 31
    CancelacionAnticipo = 32
    'ImpuestosDiferidos = 33   '//En Latinoamerica
    RecibidoEfectoClte = 34
    Plusvalia = 35
    'TraspasoBancoEfectivo = 36       '//En Latinoamerica
    'TraspasoBancoCheque = 37         '//En Latinoamerica
    'TraspasoBancoTarjeta = 38        '//En Latinoamerica
    AlbaranVenta = 39
    AlbaranCompra = 40
    AjusteAlbaranVenta = 41
    AjusteAlbaranCompra = 42
    MovimientoInput = 43
    MovimientoOutput = 44
    AsientoPredeterminado = 45
    RegularizacionDivisa = 46

    ProductoEnCurso = 47
    SalidaMaterial = 48
    ProductoTerminado = 49
    ACProvision = 50
    CompensacionACProvision = 51

    ProtestoCheque = 70          '//En Latinoamerica

    CierreOF = 71
End Enum

Public Enum enumTipoContabilizacion
    tcFacturaVenta = 0
    tcFacturaCompra = 1
    tcCobro = 2
    tcPago = 3
    tcRemesa = 4
    tcAmortizacion = 5
    tcCierreIva = 6
    tcGasto = 7
    tcCobroCambioAutomatico = 8
    tcCobroDevolucion = 9
    tcBajaElemento = 10
    tcVarios = 11
    tcTalon = 12
    '''    tcPagoPeriodico = 13
    tcPagoConcesion = 14
    tcCompensacion = 15
    tcCSB43 = 16
    tcRevision = 17
    tcRecalculoCortoPlazo = 18
    tcLeasing = 19
    tcCaja = 20
    tcRemesaPago = 21
    tcPasoInmaterial = 22
    'tcRetencion = 23 '//En Latinoamerica
    'tcImpuestoDiferido = 24 '//En Latinoamerica
    tcCobroEfectoRdo = 25
    tcPlusvalia = 26
    'tcTraspasoBanco = 27  '//En Latinoamerica
    tcReparto = 28
    tcAlbaranVenta = 29
    tcAlbaranCompra = 30
    tcMovtoInput = 31
    tcMovtoOutput = 32
    tcMovtosManuales = 33
    'tcReciboCobro = 34 '//En Latinoamerica
    'tcReciboPago = 35 '//En Latinoamerica
    tcAsientoPredeterminado = 36
    tcRegularizacionDivisa = 37
    tcProductoEnCurso = 38
    tcSalidaMaterial = 39
    tcProductoTerminado = 40
    tcACProvision = 41

    tcProtestoCheque = 70  '//En Latinoamerica
    tcCierreOF = 71
End Enum

'0: Asiento a cliente con cobro NoNegociado y NoContabilizado
'1: Asiento a cliente con cobro Cobrado y NoContabilizado
'2: Asiento a Cliente sin cobro
'3: Asiento a Banco sin cobro
'4: Asiento a cliente banco con factura contabilizada y cobro cobrado ej. TPV de venta
Public Enum enumTipoAsientoFV
    taClienteConCobroNNyNC = 0
    taClienteConCobroCyNC = 1
    taClienteSinCobro = 2
    taBancoSinCobro = 3
    taClienteBancoCobroC = 4
End Enum

Public Enum enTipoAmort
    enContable = 0
    enTecnica = 1
    enFiscal = 2
    enRealizada = 3
    enTeorica = 4
End Enum

Public Enum enumfccEstado
    fccNoContabilizado = 0
    fccContabilizado = 1
End Enum

Public Enum enumtcfvTipoCoste
    tcfvFijo = 0
    tcfvVariable = 1
End Enum

Public Enum enumtcdiTipoCoste
    tcdiDirecto = 0
    tcdiIndirecto = 1
End Enum

Public Enum enumfccTipoFactura
    fccNormal = 0
    fccGasto = 1
End Enum

Public Enum enumfclTipoGastoObra
    enumfclMaterial = 0
    enumfclGastos = 1
    enumfclVarios = 2
End Enum

Public Enum enumfvlEstadoComision
    fvlNoLiquidado = 0
    fvlLiquidado = 1
End Enum

Public Enum enumTipoImporte
    fvlImporteBruto = 0
    FvlImporteNeto = 1
End Enum

Public Enum enumTipoMovimiento
    tmInventario = 0
    tmEntAlbaranCompra = 1
    tmSalAlbaranVenta = 2
    tmEntFabrica = 3
    tmSalFabrica = 4
    tmEntTransferencia = 5
    tmSalTransferencia = 6
    tmEntAjuste = 7
    tmSalAjuste = 8
    tmEntSubcontratacion = 9
    tmSalSubcontratacion = 10
    tmCorreccion = 11
    tmSalContraActivos = 12
    tmSalRealquiler = 13
End Enum

Public Enum enumofParametrosEntrada
    ofeUltimaOperacion = 1
    ofeOfCompleta = 2
End Enum

Public Enum enumofParametrosSalida
    ofsPrimeraOperacion = 1
    ofsUltimaOperacion = 2
    ofsOperacionEstructura = 3
    ofsValeMaterial = 4
    ofsOfCompleta = 5
End Enum

Public Enum enumstkValoracionFIFO
    stkVFOrdenarPorFecha = 0
    stkVFOrdenarPorMvto = 1
End Enum

Public Enum enumTipoFicheroTrans
    tftPago = 0
    tftGasto = 1
End Enum

Public Enum enumorColor
    orBlanco = 16777215
    orRojo = 255
    orAzul = 16711680
End Enum

Public Enum enumPagoContabilizado
    PagoNoContabilizado = 0
    PagoContabilizado = 1
End Enum

Public Enum enumPagoSituacion
    NoPagado = 0
    Pagado = 1
    EnviadoTalonPagare = 3
    GeneradoCobro = 5
End Enum

Public Enum enumTipoImpresoPago
    tipDomiciliacion = 0
    tipChequePorBanco = 1
    tipCheque = 2
    tipPagare = 3
End Enum

Public Enum enumFichRemesaPago
    CSB34 = 0
    Confirming = 1
    CSB341 = 2
    CSB68 = 3
    'CSB3414 = 4
End Enum

Public Enum enumGestionAnalitica
    CCAnalitica = 1
    CCNoAnalitica = 2
End Enum

Public Enum enumpclEstado
    pclpedido = 0
    pclparcservido = 1
    pclservido = 2
    pclCerrado = 3
End Enum

Public Enum enumpvcEstado
    pvcPrograma = 0
    pvcPedido = 1
End Enum

Public Enum enumpvcPrioridad
    pvcBaja = 0
    pvcMedia = 1
    pvcAlta = 2
End Enum

Public Enum enumpvlEstado
    pvlPedido = 0
    pvlParcServido = 1
    pvlServido = 2
    pvlCerrado = 3
End Enum

Public Enum enumAsignacionAnalitica 'Enumerado para saber si la Asignacion Analitica es por Artículo por por CContable
    aaArticulo = 1
    aaCContable = 2
End Enum

Public Enum enumtbTipo
    AcumulaSaldo = 0
    SumaSaldoDeIdentificador = 1
    Texto = 2
    AcumulaSaldoPositivo = 3
    Interrogante = 4
    AcumulaSaldoDebe = 5
    AcumulaSaldoHaber = 6
    MuestraDetalle = 7
    AcumulaSaldoPatrimonio = 8
    ImporteCambioPatrimonio = 9
    SumaSaldoDeIdentificadorPatrim = 10
End Enum

Public Enum enumpceFuente
    pceArticulo = 0
    pcePreSim = 1
End Enum

Public Enum enumpceTipoCoste
    pceSimulacion = 0
    pcePresupuesto = 1
End Enum

Public Enum enumpceEstado
    pcePresupuestado = 0
    pceAceptado = 1
    pceRechazado = 2
End Enum

Public Enum enumtpTipoPrevision
    tpPorArticulo = 0
    tpPorCliente = 1
    tpArticuloCliente = 2
    tpZona = 3
    tpClienteTipoFamiliaSubFamilia = 4
    tpClienteTipoFamiliaSubFamiliaFormato = 5
End Enum

Public Enum enumplEstadoLinea
    plNoConfirmada = 0
    plConfirmada = 1
End Enum

Public Enum enummpAgrupAlbaran
    mpProveedor = 0
    mpPedido = 1
End Enum

Public Enum enummpAgrupFactura
    mpProveedor = 0
    mpAlbaran = 1
End Enum

Public Enum enummpTipoFacturacion
    mpGeneral = 0
    mpAutoFacturacion = 1
End Enum

Public Enum enumpcEstadoPrograma
    pcNoActivo = 0
    pcActivo = 1
End Enum

Public Enum enumpdTipoDireccion
    pdDireccionPedido = 0
    pdDireccionFactura = 1
    pdDireccionPago = 2
End Enum

Public Enum enumrControlProduccion
    rNo = 0
    rSi = 1
End Enum

Public Enum enumtrTipoOperacion
    trInterna = 0
    trExterna = 1
End Enum

Public Enum enumSimulacionTesoreria
    Cobro = 0
    Pago = 1
    FVNoContabilizada = 2
    FCNoContabilizada = 3
    AVNoFacturado = 4
    ACNoFacturado = 5
    PVPendiente = 6
    PCPendiente = 7
    OVNoFacturada = 8
    OCNoFacturada = 9
    BancoPropio = 10
    CobroPeriodico = 11
    PagoPeriodico = 12
    Promotoras = 13
End Enum

Public Enum enumtfSexo
    tfHombre = 0
    tfMujer = 1
End Enum

Public Enum enumtfEstadoCivil
    tfSoltero = 0
    tfCasado = 1
    tfDivorciado = 2
    tfViudo = 3
End Enum

Public Enum enumtaValoracion
    taPrecioEstandar = 0
    taPrecioFIFOFecha = 1
    taPrecioFIFOMvto = 2
    taPrecioMedio = 3
    taPrecioUltCompra = 4
End Enum

Public Enum enumtaValoracionDetalle
    taPrecioFIFOFecha = 0
    taPrecioFIFOMvto = 1
    taPrecioMedio = 2
    taPrecioStockFecha = 3
End Enum

Public Enum enumtaValoracionSalidas
    taNoRecalcular = 0
    taRecalcular = 1
    taMantenerPrecio = 2
End Enum

Public Enum enumtpmTipoMovimiento
    tpmInventario = 0
    tpmOutput = 1
    tpmInput = 2
End Enum

Public Enum TipoDiaObraEnum
    ctoNormal = 0
    ctoFestivo = 1
    ctoVacacion = 2
End Enum

Public Enum enumiaAfectaFactura
    iaNegativo = 0
    iaPositivo = 1
    iaNoAfecta = 2
End Enum
'DAVID VELASCO 16/10/2024
'AÑADO NUEVOS ESTADOS PARA EL CAMBIO DE MEDICIONES
'ANTIGUO (0 = PROYECTADO, 1 = ACTIVA, 2 = TERMINADO)
'-------
'ocProyectado = 0
'ocComenzado = 1
'ocTerminado = 2
'NUEVO(0 = No iniciada, 1 = Activa, 2 = Terminada, 3 = Parada, 4 = Liquidación)
'-------
'ocProyectado = 0
'ocComenzado = 1
'ocTerminada = 2
'ocTerminado = 3
'ocLiquidacion = 4
'EL VALOR QUE SE VE SE CAMBIA DESDE TRADUCCION EN EL MANAGER
Public Enum enumocEstado
    ocProyectado = 0
    ocComenzado = 1
    ocTerminado = 2
    ocParada = 3
    ocLiquidacion = 4
End Enum

'David Velasco 11/11/22
Public Enum EstructuraFerralla
    Pos = 0
    Zuncho = 1
    Muro = 2
    'Prueba
    PosExtremos = 3
End Enum

Public Enum enumTipoObra
    tpObra = 0
    tpalquiler = 1
    tpObraPromo = 2
End Enum

Public Enum enumocEstadoFactura
    ocNoFacturado = 0
    ocParcFacturado = 1
    ocFacturado = 2
End Enum

Public Enum enumocSegurosTipoImporte
    ocImporteNeto = 0
    ocImporteBruto = 1
End Enum

Public Enum enumocFilterOptions
    ocMyProjects = 0
    ocAllProjects = 1
End Enum

Public Enum enumocenEstadoFactura
    ocenNoFacturado = 0
    ocenFacturado = 1
End Enum

Public Enum enumocenEstado
    ocenPendiente = 0
    ocenTerminado = 1
End Enum

Public Enum enumogEstadoFactura
    ogNoFacturado = 0
    ogFacturado = 1
End Enum

Public Enum enumogTipoFacturacion
    ogPorVencimientos = 1
    ogPorPartes = 2
End Enum

Public Enum enumgcFacturado
    ogcFacturado = 1
    ogcNoFacturado = 0
End Enum

Public Enum enumgcPagado
    ogcPagado = 1
    ogcNoPagado = 0
End Enum

Public Enum enumomEstadoFactura
    omNoFacturado = 0
    omFacturado = 1
    omParcFacturado = 2
End Enum

Public Enum enumomEstado
    omPendiente = 0
    omServido = 1
    omParcServido = 2
End Enum

Public Enum enumomTipoFacturacion
    omPorCantidad = 0
    omPorVencimientos = 1
    omPorExpedicion = 2
End Enum

Public Enum enumomATipoFacturacionAlquiler
    omAPorVencimientos = 1
    omAPorExpedicion = 2
    omAPorAlquiler = 3
End Enum

Public Enum enumomACalculoRiesgoCliente
    omANoCalculoRiesgo = 1
    omACalculoRiesgoPorObra = 2
    omACalculoRiesgoPorCliente = 3
End Enum

Public Enum enumomcActualizado
    omcNoActualizado = 0
    omcActualizado = 1
    omcSinGestion = 2
    omcParcActualizado = 3
End Enum

Public Enum enumomcTipoMaterial
    omcAlmacen = 0
    omcPedidoCompra = 1
End Enum

Public Enum enumomodEstadoFactura
    omodNoFacturado = 0
    omodFacturado = 1
End Enum

Public Enum enumomodEstado
    omodPendiente = 0
    omodTerminado = 1
End Enum

Public Enum enumomodTipoFacturacion
    omodPorVencimientos = 1
    omodPorHoras = 2
End Enum

Public Enum enummcFacturado
    omcFacturado = 1
    omcNoFacturado = 0
End Enum

Public Enum enumopcEstado
    opcPresupuestado = 0
    opcAceptado = 1
    opcRechazado = 2
End Enum

Public Enum optaTipo
    optaPrecioArticulo = 0
    optaDescuentoPorFamilia = 1
    optaPorcentajeSeguro = 2
End Enum

Public Enum optaTipoDtos
    optaDtoGeneral = 0
    optaDtoPorTipo = 1
    optaDtoPorFamilia = 2
End Enum

Public Enum enumotaPrioridad
    otaBaja = 0
    otaMedia = 1
    otaAlta = 2
End Enum

Public Enum enumotaEstado
    otaPlanificada = 0
    otaComenzada = 1
    otaTerminada = 2
End Enum

Public Enum otaTipo
    otaPrecioArticulo = 0
    otaDescuentoPorFamilia = 1
    otaPorcentajeSeguro = 2
    otaTarifa = 3
    otaExcesoContadores = 4
End Enum

Public Enum otaTipoDtos
    otaDtoGeneral = 0
    otaDtoPorTipo = 1
    otaDtoPorTipoFamilia = 2
End Enum

Public Enum otaTipoSeguros
    otaSegGeneral = 0
    otaSegArticulo = 1
    otaSegPorTipo = 2
    otaSegPorTipoFamilia = 3
End Enum

Public Enum enumotFacturable
    otNoFacturable = 0
    otFacturable = 1
End Enum

Public Enum enumotEstadoFactura
    otNoFacturado = 0
    otParcFacturado = 1
    otFacturado = 2
End Enum

Public Enum enumotEstado
    otPendiente = 0
    otPlanificado = 1
    otComenzado = 2
    otTerminado = 3
End Enum

Public Enum enumotTipoFacturacion
    otfPorVencimientos = 1
    otfPorConceptos = 2
    otfPorUdsObra = 3
    otfPorAlquiler = 4
End Enum

Public Enum enumotfEstadoCIVtos
    otfvNoFacturado = 0
    otfvFacturado = 1
    otfvTodos = 2
End Enum

Public Enum enumotfEstado
    otfFacturado = 1
    otfNoFacturado = 0
End Enum

Public Enum enummcoAgrupFacturaVto
    mcoSinAgrupar = 0
    mcoClienteFechaVto = 1
    mcoObraCliente = 2
    mcoObraTrabajo = 3
End Enum

Public Enum enumotfTipoFactura
    otfVencimientos
    otfHorasMOD
    otfGastos
    otfAlquiler
    otfMateriales
    otfOrdenesTrabajo
    otfAlbaranes
End Enum

Public Enum enumotoTipoVer
    tpVerHoras = 0
    tpVerOperarios = 1
End Enum

Public Enum enumotpEstado
    otpPendiente = 0
    otpComenzado = 1
    otpPlanificado = 2
    otpTerminado = 3
End Enum

Public Enum enumottfCadencia
    ottfDia = 0
    ottfSemana = 1
    ottfMes = 2
    ottfAño = 3
End Enum

Public Enum enumottfClaseVencimiento
    ottfMaterial = 0
    ottfMod = 1
    ottfCentro = 2
    ottfGasto = 3
    ottfVarios = 4
    ottfTrabajo = 5
End Enum

Public Enum enumovEstadoFactura
    ovNoFacturado = 0
    ovFacturado = 1
End Enum

Public Enum enumofEstado
    ofePlanificada = 0
    ofeProgramada = 1
    ofeLanzada = 2
    ofeIniciada = 3
    ofeTerminada = 4
    ofeOfAnulada = 5
End Enum

Public Enum enumofoTipoOrigen
    ofoPedidoVenta = 0
    ofoStockPuntoPedido = 1
    ofoExplosionOrden = 2
    ofoPrevisionVenta = 3
    ofoObra = 4
    ofoMantenimiento = 5
    ofoPrograma = 6
    ofoSolicitudTransferencia = 7
End Enum

Public Enum enumorTiempo
    ortDias = 0
    ortHoras = 1
    ortMinutos = 2
    ortSegundos = 3
End Enum

Public Enum enumtrTiempo
    trtDias = 0
    trtHoras = 1
    trtMinutos = 2
    trtSegundos = 3
End Enum

Public Enum enumcvTipoVencimiento
    cvFirma = 1
    cvRecibo = 2
    cvLlaves = 3
    cvAnulacion = 4
    cvTrabajos = 5
End Enum

Public Enum opccEstadoCivil
    opccSoltero = 0
    opccSoltera = 1
    opccCasado = 2
    opccCasada = 3
    opccSeparado = 4
    opccSeparada = 5
    opccDivorciado = 6
    opccDivorciada = 7
    opccViudo = 8
    opccViuda = 9
    opccOtros = 10
End Enum

Public Enum opccRegimen
    opccGananciales = 0
    opccSepBienes = 1
    opccOtros = 2
End Enum

Public Enum enumoplEstado
    oplNoVendido = 0
    oplReservado = 1
    oplVendido = 2
    oplVinculado = 3
End Enum

Public Enum enumoOplvEstadoVto
    OplvNoFacturado = 0
    OplvFacturado = 1
    OplvTodos = 2
End Enum

Public Enum enumoptvCadencia
    ottfDia = 0
    ottfSemana = 1
    ottfMes = 2
    ottfAño = 3
End Enum

Public Enum enumoptvTipoFactura
    optvNormal = 0
    optvAnticipo = 1
    optvFinal = 2
End Enum

Public Enum enumTipoMarca
    MarcaNumerica = 0
    MarcaTexto = 1
End Enum

Public Enum enumTipoChequeo
    tcCalidad = 0
    tcImplantacion = 1
End Enum

Public Enum enumEstadoIncidencia
    eiPendiente = 0
    eiEnCurso = 1
    eiFinalizada = 2
End Enum

Public Enum enumTipoIncidencia
    tcIncidencia = 0
    tcRechazo = 1
End Enum

Public Enum enumPacAceptacion
    ePacAceptado = 0
    ePacNoAceptado = 1
    ePacCondicional = 2
End Enum

Public Enum enumTipoPautaCalidad
    tpcRecepcion = 0
    tpcProceso = 1
    tpcControlFinal = 2
End Enum

Public Enum enumEstadoRecepcionLinea
    erlPendiente = 0
    erlAceptada = 1
    erlNoAceptada = 2
End Enum

Public Enum enumocdEstadoCliente
    ecPendiente = 0
    ecActualizado = 1
End Enum

Public Enum enumocdEstadoCompraVenta
    ecvPendiente = 0
    ecvLanzado = 1
End Enum

Public Enum enumtoTipoOT
    Correctivo = 0
    Preventivo = 1
    Inversiones = 2
    Control = 3
    Resto = 4
End Enum

Public Enum enumOTTipoLineasPrev
    OTMaterial = 0
    OTMod = 1
    OTContrata = 2
    OTGastos = 3
End Enum

Public Enum enumOTTipoLineasControl
    OTMaterial = 0
    OTMod = 1
    OTContrata = 2
    OTGastos = 3
End Enum

'*** ESTE ENUMERADO DEBE COINCIDIR CON LOS ID DE LOS ESTADOS DEFINIDOS PARA ESTA ENTIDAD
'*** (ESTOS ID DEBEN TENER LA MARCA DE 'SISTEMA')
Public Enum enumEstadoOfertaComercial
    oceEnDiseño = 0
    oceEnCurso = 1
    oceAceptada = 2
    oceRechazada = 3
    oceContrato = 4
End Enum

Public Enum enumOfertaCabecera
    ocEnCurso = 0
    ocCompletada = 1
    ocAdjudicada = 2
    ocCerrada = 3
End Enum

Public Enum enumOrigenPedido
    Manual = 0
    Oferta = 1
    Solicitud = 2
    Almacen = 3
    Programa = 4
    PedidoCompra = 5
    Copia = 6
    EDI = 7
End Enum

Public Enum enumofOrigen
    orManual = 0
    orSolicitud = 1
    orObras = 2
    orMantenimiento = 3
End Enum

Public Enum enumscEstado
    scNinguno = -1
    scSolicitado = 0
    scSolicitaOferta = 1
    scPedido = 2
    scDenegada = 3
    scCerrada = 4
End Enum

Public Enum enumRespuesta
    Ok = 1
    Cancel = 0
End Enum

Public Enum enumdTipoDiario
    Contable = 0
    Analitico = 1
    Consolidacion = 2
    Exportacion = 3
    Borrado = 4
    ConsolidacionAnalitico = 5
    Eliminacion = 6
End Enum

Public Enum enumTipoPantallaAsiento
    AsientoPredefinido = 0
    ModificarAsiento = 1
    AsientoNuevo = 2
    ModificarSimulacion = 3
    AsientoReparto = 4
    CopiarAsiento = 5
End Enum

Public Enum enumTipoGasto
    tgGasto = 0
    tgCompra = 1
    tgInversion = 3
    tgTodo = 4
End Enum

Public Enum enumTipoDetalle
    tpCobroAtrasado = 1
    tpPagoAtrasado = 2
    tpCobroPeriodo = 3
    tpPagoPeriodo = 4
    tpRemesa = 5
End Enum

Public Enum enumOrigenDetalle
    tdPago = 0
    tdCobro = 1
    tdLeasing = 2
End Enum

Public Enum enumprtTipoParametro
    prtBoolean = 0
    prtString = 1
    prtDate = 2
    prtInteger = 3
    prtDouble = 4
    prtEnumerado = 5
    prtEntidad = 6
End Enum

Public Enum enumTipoMovimientoCaja
    tmcSalida = 0
    tmcEntrada = 1
End Enum

Public Enum enumEstadoDaa
    PendienteResponder = 0
    Respondido = 1
    Todos = 2
End Enum

Public Enum enumTipoDaa
    UE = 0
    OI = 1
    EX = 2
End Enum

Public Enum enumTipoFactura
    tfNormal = 0
    tfObra = 1
    tfCertificacion = 2
    tfPromocionObra = 3
    tfPromocionObraFinal = 4
End Enum

Public Enum enumpaContadorFecha
    Contador = 0
    Fecha = 1
End Enum

Public Enum emumpaCriterioPlanificaion
    DesdeUltimaIntervencion = 0
    DesdeInicio = 1
End Enum

Public Enum enContador
    Manual = 0
    Contador = 1
End Enum

Public Enum enumtaTipoAnalitica
    Diario = 0
    AsientoPredeterminado = 1
    AsientoNuevo = 2
End Enum

Public Enum enumEstadoDoc
    Pendiente = 0
    Traspasado = 1
End Enum

Public Enum TipoInventario
    PrimerMovimiento = 0
    UltimoMovimiento = 1
End Enum

Public Enum enumTipoPlantilla
    dcmdWord = 0
    dcmdExcel = 1
End Enum

Public Enum enumEstadoCertificacion
    ecPendiente = 0
    ecAceptada = 1
    ecFacturado = 2
End Enum

Public Enum enumTipoRetencion
    troSobreBI = 0
    troSobreTotal = 1
End Enum

Public Enum enumOMPrecioCoste
    pcEstandar = 0
    pcUltimo = 1
    pcMedio = 2
    pcFIFODoc = 3
    pcFIFOFec = 4
    pcCompraProv = 5
    pcPresup = 6
End Enum

Public Enum enumOMPrecioVenta
    pvCliente = 0
    pvTarifa = 1
    pvPresup = 2
End Enum

Public Enum enumClaseObra
    FacturacionControl = 0
    Facturacion = 1
    Control = 2
End Enum

Public Enum enumEstAvalProv
    Reclamado = 0
    Generado = 1
    Finalizado = 2
End Enum

Public Enum enumTipoCertificacion
    ClienteProduccion = 0
    Cliente = 1
    Produccion = 2
End Enum

Public Enum enumTipoCertificacionCP
    Cliente = 1
    Produccion = 2
End Enum

Public Enum enumbpTipoFecha
    FechaApunte = 0
    FechaCierre = 1
End Enum

Public Enum enumbpTipoPeriodo
    PorPeriodo = 0
    PorFecha = 1
End Enum

Public Enum enumbpTipoMoneda
    MonedaA = 0
    MonedaB = 1
End Enum

Public Enum enumbpTipoInforme
    PorMeses = 0    '//Balance, con una columna por cada mes.
    Acumulado = 1   '//Balance simple, con una única columna, por defecto.
    Patrimonio = 2  '//Balance de referencias cruzadas, por cambio y cuenta de patrimonio
End Enum

Public Enum enumbpTipoBalance  '//En el diseño del Balance se deberá interpretar alguno de los siguientes tipos.
    PorCuenta = 0
    PorCentroGestion = 1
    PorAgrupacion = 2
    PorPatrimonio = 3
End Enum

Public Enum enumbpTipoColumna
    Real = 1
    Porcentaje = 2                  '//Necesita para calcularse, que se haya calculado antes la Real.
    VariacionRealAñoAnterior = 3    '//Necesita para calcularse, que se haya calculado antes la Real y AñoAnterior.
    Acumulado = 4
    VariacionRealAcumulado = 5      '//Necesita para calcularse, que se haya calculado antes la Real y Acumulado.
    Presupuesto = 6
    VariacionRealPresupuesto = 7    '//Necesita para calcularse, que se haya calculado antes la Real y Presupuesto.
    RealTributario = 8
    VariacionRealTributario = 9     '//Necesita para calcularse, que se haya calculado antes la NIIF y el Tributario.
    NotasMemoria = 10
End Enum

Public Enum enumofTipoControlEstructura
    ofTodos = 0
    ofDescuentoMateriales = 1
    ofProductoTerminado = 2
End Enum

Public Enum enumTipoEntrega
    Anticipo = 0
    Fianza = 1
    Retencion = 2
End Enum

Public Enum enumTipoFacturacionPromociones
    PorLocal = 0
    PorCliente = 1
End Enum

Public Enum enumpaBaseCalculoLeasing
    EnumpaBaseBCNoNominal = 0
    EnumpaBCNominal = 1
End Enum

Public Enum TipoRetencionImpuestos
    DespuesImpuestos = 0
    AntesImpuestos = 1
End Enum

Public Enum Circuito
    Ventas = 0
    Compras = 1
End Enum

Public Enum enumVerificarEDI
    vediSinVerificar = 0
    vediUltimoAlb = 1
    vediCantidad = 2
    vediAcumula = 3
    vediAmbas = 4
End Enum

Public Enum enumEquivalencia
    eqvPrograma = 1
    eqvPedido = 2
    eqvNoTratar = 3
End Enum

Public Enum enumTipoFactCompra
    tfcNormal = 0
    tfcConcesion = 1
    tfcLeasing = 2
End Enum

Public Enum enumTipoLineaTrabajo
    tltTrabajo = 0
    tltCapitulo = 1
    tltPorcentajeConcepto = 2
    tltTrabajoConcepto = 4
End Enum

Public Enum enumTipoLineaTrabajoSinPorcentajes
    tltTrabajo = 0
    tltCapitulo = 1
    tltTrabajoConcepto = 4
End Enum

Public Enum enumTipoLineaTrabajoSoloPorcentajes
    tltPorcentajeConcepto = 2
End Enum

Public Enum enumTipoCertificacionCabecera
    tccTrabajo = 0
    tccCapitulo = 1
End Enum

Public Enum otaTipoCalcSeg
    Porcentaje = 0
    ImporteFijo = 1
    PrecioUdFactAlquiler = 2
End Enum

Public Enum TipoExcesosContadores
    otaETCGeneral = 0
    otaETCArticulo = 1
    otaETCPorTipo = 2
    otaETCPorTipoFamilia = 3
End Enum

Public Enum enumOrepComision
    OrepArticulo = 0
    OrepTipoFamiliaSubFamilia = 1
    OrepTipoFamilia = 2
    OrepTipo = 3
    OrepGeneral = 4
End Enum

Public Enum enumTipoDocumento
    tdTicket = 0
    tdFactura = 1
End Enum

Public Enum enumTipoCodAutomatica
    Familia = 0
    SubFamilia = 1
End Enum

Public Enum RiesgoFactoring
    RiesgoFactoring = 1
    RiesgoRemesas = 0
    Todos = 2
End Enum

#Region " MRP "

Public Enum enumTipoOrigenPlanif
    Ordenes = 0
    ComprasenCurso = 1
    ProgramasCompras = 2
    Pedidos = 3
    Almacen = 4
    Previsiones = 5
    Programas = 6
    SolicitudCompra = 7
    Obras = 8
    Mnto = 9
    ExpOrdenes = 10
    ExpPedidos = 11
    ExpPrevisiones = 12
    ExpProgramas = 13
    ExpObras = 14
    ExpMnto = 15
    PuntoPedido = 16
    ExpAlmacen = 17
    SolicitudTransferencia = 18
    ExpSolicitudTransferencia = 19
End Enum

Public Enum TipoInsertCompra
    ProgramaVenta = 0
    PedidoVenta = 1
    PrevisionVenta = 2
    OrdenFabricacion = 3
    OrdenCompra = 4
    OrdenFabIntermedio = 5
    OrdenCompIntermedio = 6
    ObraCompra = 7
    MantenimientoCompra = 8
    SolicitudCompra = 9
    ProgramaCompra = 10
    ProgramaCompIntermedio = 11
    PuntoPedidoTerminados = 12
    PuntoPedidoIntermedios = 13
    PuntoPedidoCompra = 14
    SolicitudTransferenciaTerminados = 15
    SolicitudTransferenciaIntermedios = 16
    SolicitudTransferenciaCompra = 17
End Enum

Public Enum TipoInsertFabricacion
    ProgramaVenta = 0
    PedidoVenta = 1
    PrevisionVenta = 2
    OrdenFabricacion = 3
    OrdenFabIntermedio = 4
    ObraCompra = 5
    MantenimientoCompra = 6
    PuntoPedidoTerminados = 7
    PuntoPedidoIntermedios = 8
    SolicitudTransferenciaTerminados = 9
    SolicitudTransferenciaIntermedios = 10
End Enum

Public Enum EnumGridAgrup
    SinAgrupar = 0
    AgrupArticulo = 1
    AgrupFecha = 2
End Enum

#End Region

Public Enum TipoClasificacionProveedor
    Proveedor = 0
    Acreedor = 1
    InmovilizadoCortoPlazo = 2
    InmovilizadoLargoPlazo = 3
End Enum

Public Enum enumFvcCalculo
    fvcSeguro = 0
    fvCTasaResiduos = 1
End Enum

Public Enum enumOtEstadoFact
    enumOtNoFacturado = 0
    enumOtFacturado = 1
End Enum

Public Enum enumOperadores
    oIgual = 0
    oMayor = 1
    oMenor = 2
    oMayorIgual = 3
    oMenorIgual = 4
    oLike = 5
    oNoLike = 6
    oDistinto = 7
End Enum

Public Enum enumOperandos
    oAND = 0
    oOR = 1
End Enum

Public Enum enumacDevolucionRealquiler
    acdPendienteDevolucion = 0
    acdParcialmenteDevuelto = 1
    acdDevuelto = 2
End Enum

Public Enum enumtvcEstadoTransporte
    tvcEnCurso = 0
    tvcCerrada = 1
End Enum

Public Enum EnumTrimestreDeclaracion
    enumTrimestre1 = 1
    enumTrimestre2 = 2
    enumTrimestre3 = 3
    enumTrimestre4 = 4
End Enum

Public Enum EnumFechasObraTrabajo
    enumFechaInicioObra = 0
    enumFechaFinObra = 1
    enumFechaInicioTrabajo = 2
    enumFechaFinTrabajo = 3
End Enum

Public Enum EnumEstadoEvaluador
    Configurando = 0
    Evaluado = 1
    Generado = 2
End Enum

Public Enum EnumNivelesAnalitica
    Nivel0 = 0
    Nivel1 = 1
    Nivel2 = 2
    Nivel3 = 3
    Nivel4 = 4
    Nivel5 = 5
End Enum

Public Enum enumTipoEvaluacion
    Caracteristica = 0
    CondicionEstructura = 1
    CondicionRuta = 2
    AccionEstructura = 3
    AccionRuta = 4
End Enum

Public Enum TipoAccion
    Agregar = 0
    Modificar = 1
    Eliminar = 2
End Enum

Public Enum enumotTipoObra
    otInterna = 0
    otExterna = 1
End Enum

Public Enum DiposicionBarrica
    Normal
    Cuña
    Panal
    ZigZag
    CuñaCimaAlterna
End Enum

Public Enum OrientacionBarrica
    Horizontal
    Vertical
End Enum

Public Enum LlenadoBarrica
    Horizontal
    Vertical
End Enum

Public Enum BdgTipoCartillista
    Interno = 0
    Externo = 1
End Enum

Public Enum EsUltimoAnalisis
    Todos = 0
    Si = 1
End Enum

Public Enum EnumConVino
    ConVino = 0
    SinVino = 1
    Todos = 2
End Enum

Public Enum enumEntidad
    PedidoProg = 1
    Albaran = 2
    Factura = 3
End Enum

Public Enum enumRHTipoSancion
    Sancion = 0
    Amonestacion = 1
    Otros = 2
End Enum

Public Enum enumRHTipoParte
    Baja = 0
    Confirmacion = 1
    Alta = 2
    Otros = 3
End Enum

Public Enum enumRHTipoIT
    Accidente = 0
    Enfermedad = 1
    Maternidad = 2
    Otros = 3
End Enum

Public Enum enumBajaAlta
    Baja = 0
    Alta = 1
End Enum

Public Enum enumSexo
    Hombre
    Mujer
End Enum

Public Enum enumComenObser
    Comentario = 0
    ObservacionFC = 1
End Enum

Public Enum enumPrevReal
    Previsto = 0
    Realizado = 1
    Todos = 2
End Enum

Public Enum ClienteFacturaEDI
    ClienteCabeceraGrupo = 0
    ClienteAFacturar = 1
End Enum

Public Enum enumModificable
    Modificable = 0
    Protegida = 1
End Enum

Public Enum enumModificableCI
    Modificable = 0
    Protegida = 1
    Todos = 2
End Enum

Public Enum enumEstadoEvaluacionRiesgo
    Pendientes = 0
    Cerradas = 1
    Todas = 2
End Enum

Public Enum enumRHEstadoContrato
    Baja
    Alta
    Curso
End Enum

Public Enum enumTipoDocumentoCreado
    PedidoCompra
    PedidoVenta
    AlbaranCompra
    AlbaranVenta
    FacturaCompra
    FacturaVenta
    OrdenFabricacion
    OfertaCompra
    SolicitudCompra
    AlbaranVentaAlquiler
    ProgramaVenta
    Articulo
    'David Velasco 28/8/22
    FacturaCompraPiso
End Enum

Public Enum TipoRetencionIRPF
    Profesionales = 0
    Alquileres = 1
    RegimenAgricola = 2
End Enum

Public Enum ClaveOperacion
    ResumenFacturas = 0
    ResumenTicket = 1
    FacturaVariosTiposImpositivos = 2
    FacturaRectificativa = 3
    AdquisicionesAgenciasViajes = 4
    RegimenEntidadesIVAIGIC = 5
    RegimenOroInversion = 6
    InversionSujetoPasivo = 7
    Tickets = 8
    RectificacionErroresRegistrales = 9
    AdquisicionesAMinoristasIGIC = 10
    AdquisicionesIntracomunitariasBienes = 11
    IVAIGICDevengadoPendienteEmitirFactura = 12
    IVAIGICFacturadoPendienteDevengar = 13
    FacturacionPrestacionesAgenciasViajes = 14
    FacturaEmitidaSustitucionTiquesFactDecla = 15
    OperacionesBienesUsadosObjetosArteETC = 16
    OperacionesArrendamiento = 17
    SubvencionesAyudas = 18
    CobrosPorCuentaDeTerceros = 19
    OperacionesSeguros = 20
    ComprasAgenciasViajes = 21
    OperacionesSujetasImpuesto = 22
    OperacionesCompensacionesAgriGanaPesq = 23

End Enum

Public Enum enumTipoExpedicion
    tePedido = 0
    teObra = 1
    teAlquiler = 2
    teAlquilerCambioMaquina = 3
    teAlquilerRetorno = 4
End Enum

Public Enum enumTipoIVA
    OperacionesInterioresCorrientes = 0
    OperacionesInterioresBienesInversion = 1
    OperacionesImportacionesCorrientes = 2
    OperacionesImportacionesBienesInversion = 3
    OperacionesIntracomunitariasCorrientes = 4
    OperacionesIntracomunitariasInversion = 5
    OperacionesInversionSujetoPasivo = 6
    OperacionesNoDeducibles = 7
    OperacionesCompensacionesAGP = 8
    OperacionesExportacion = 9
    OperacionesInversionSujetoPasivoInversion = 10
End Enum

Public Enum enumTipoOperacionIntra
    enumTipoOperIntraA = 0
    enumTipoOperIntraB = 1
End Enum

Public Enum EnumTipoCampoDeclaracion
    enumTipoNumerico = 0
    enumTipoTexto = 1
    enumTipoFecha = 2
    enumTipoAlfaNumerico = 3
    enumTipoTextoSinConvertir = 4
    enumTipoNumericoEDI = 5
    enumTipoArrayBytes = 6
    enumTipoNumericoNAEAT = 7
    enumTipoNumericoSigno = 8
    enumTipoNumericoSignoMenos = 9
    enumTipoNumericoSignoVacio = 10
End Enum

Public Enum enumtbTipoDeclaracion
    AcumulaSaldo = 0
    SumaSaldoDeIdentificador = 1
    Texto = 2
    AcumulaSaldoPositivo = 3
    Interrogante = 4
    MuestraDetalle = 7
    DatosPresentacion = 8
    DatosTablaGeneral = 9
    Funcion = 10
    Bucle = 11
    Definicion = 12
    Totales = 13
    TotalesVista = 14
    BucleVista = 15
    EncabezadoXML = 16
    RaizXML = 17
    SubBucle = 18
    SubBucleVista = 19
    BucleVistaAtributoDAA = 20
    SubBucleVistaAtributoDAA = 21
    EncabezadoXMLAtributoDAA = 22
    RaizXMLContenido = 23
    EncabezadoXMLContenido = 24
    BucleDatosAnterior = 25
    DefinicionAtributoDAA = 26
    DefinicionAtributoXML = 27
    BucleXMLInfinito = 28
    EncodingXML = 29
End Enum

Public Enum enumTipoDocIdent
    NIF = 1
    NIFOperadorIntra = 2
    Pasaporte = 3
    DocOficialPais = 4
    CertificiadoResiFiscal = 5
    OtroDoc = 6
End Enum

Public Enum enumTipoSalidaFicheroDeclaracion
    FicheroPlanoFijo = 0
    FicheroXML = 1
    FicheroPlanoDelimitado = 2
End Enum

Public Enum enumFichDelimFila
    Ninguno = 0
    CRLF = 1
    CR = 2
    LF = 3
    PuntoyComa = 4
    Tabulador = 5
    BarraVertical = 6
End Enum

Public Enum enumFichDelimCol
    Ninguno = 0
    PuntoyComa = 1
    Coma = 2
    Tabulador = 3
    BarraVertical = 4
    PipeLine = 5
End Enum

Public Enum enumFichCalifTexto
    Ninguno = 0
    ComillasDobles = 1
    ComillasSencillas = 2
End Enum

'//Los valores del siguiente enumerado se corresponden con los distintos tipos de albaran que son de sistema.
Public Enum enumTipoAlbaran
    NoEsDeSistema = -1
    Desconocido = 0
    Normal = 1
    Servicio = 2
    Deposito = 3
    Consumo = 4
    RetornoAlquiler = 5
    DevolucionGeneral = 6
    DevolucionPedido = 7
    DevolucionCalidad = 8
    Intercambio = 9
    ExpedDistribuidor = 10
    AbonoDistribuidor = 11
End Enum

Public Enum EnumTipoFormasPagoTPV
    enumTipoEfectivo = 0
    enumTipoTarjeta = 1
    enumTipoVale = 2
    enumTipoMultiples = 3
    enumTipoCliente = 4
End Enum

Public Enum enumSTLEstadoLinea
    STLSolicitada = 0
    STLRecibida = 2
    STLCerrada = 3
End Enum

Public Enum enumCRMEstadosVenta
    NoExiste
    Pipeline
    MejorCaso
    Aceptado
    Cerrado
End Enum

Public Enum ContadorEntidad
    PedidoVenta = 0
    PedidoCompra = 1
    AlbaranVenta = 2
    AlbaranCompra = 3
    FacturaVenta = 4
    FacturaCompra = 5
    AlbaranVentaTPV = 6
End Enum

Public Enum enumTipoSentencia
    SentenciaMDX
    SentenciaSQL
End Enum

Public Enum enumTipoAreaGrafico
    Comercial
    Compras
    Financiero
    CompraVenta
    CRM
    Stocks
    Calidad
    Proyectos
    RRHH
    Produccion
    CorrectivoPreventivo
    TPV
End Enum

Public Enum enumTipoGrafico
    Column = 3
    Bar = 5
    Pie = 0
    Doughnut = 6
    Area = 2
    Line = 1
    Spline = 9
    StackedArea = 12
    StackedBar = 11
    StackedColumn = 10
End Enum

Public Enum enumEstadoIncidenciaCRM
    Abierta
    EnCurso
    Cerrada
End Enum

Public Enum enumPermisoFactElec
    Ninguno = 0
    SoloFacturaPDF = 1
    SoloFacturaXML = 2
    Ambos = 3
End Enum

Public Enum enumCodFacturaeIVA
    IVA = 1
    IPSI = 2
    IGIC = 3
    IRPF = 4
    Otro = 5
    ITPDAJD = 6
    IE = 7
    Ra = 8
    IGTECM = 9
    IECPCAC = 10
    IIIMAB = 11
    ICIO = 12
    IMVDN = 13
    IMSN = 14
    IMGSN = 15
    IMPN = 16
    REIVA = 17
    REIGIC = 18
    REIPSI = 19
End Enum

Public Enum enumCodFacturaeFP
    Contado = 1
    ReciboDom = 2
    Recibo = 3
    Transferencia = 4
    LetraAceptada = 5
    CreditoDocumentario = 6
    ContratoAdjudicacion = 7
    LetraCambio = 8
    PagareOrden = 9
    PagareNoOrden = 10
    Cheque = 11
    Reposicion = 12
    Especiales = 13
End Enum

Public Enum enumCodFacturaeUDMedida
    Unidades = 1
    Horas = 2
    Kilogramos = 3
    Litros = 4
    Otros = 5
    Cajas = 6
    Bandejas = 7
    Barriles = 8
    Bidones = 9
    Bolsas = 10
    Bombonas = 11
    Botellas = 12
    Botes = 13
    TetraBriks = 14
    Centrilitos = 15
    Centimetros = 16
    Cubos = 17
    Docenas = 18
    Estuches = 19
    Garrafas = 20
    Gramos = 21
    Kilometros = 22
    Latas = 23
    Manojos = 24
    Metros = 25
    Milimetros = 26
    Pack6 = 27
    Paquetes = 28
    Raciones = 29
    Rollos = 30
    Sobres = 31
    Tarrinas = 32
    MetroCubico = 33
    Segundo = 34
    Vatio = 35
End Enum

Public Enum enumFumador
    NoFumador
    MenosDeDiez
    EntreDiezyVeinte
    MasDeVeinte
    ExFumador
End Enum

Public Enum enumBebedor
    NoBebedor
    Ligero
    Moderado
    Excesivo
    ExBebedor
End Enum

Public Enum enumRHTipoFormacion
    Interno
    Externo
End Enum

Public Enum enumRHEstadoEncuesta
    Pendiente
    Realizada
End Enum

Public Enum enumRHTipoEncuesta
    SatisfaccionTrabajador
    SatisfaccionFormacion
    SatisfaccionCliente
    SatisfaccionProveedor
    SatisfaccionCuenta
    General
End Enum

Public Enum enumTipoRevision
    Puntual = 0
    Permanente = 1
End Enum

Public Enum enumRHTipoTurno
    Mañana = 0
    Tarde = 1
    Ambos = 2
End Enum

Public Enum enumEstadoFacturaSinConta
    NoValidado = 0
    Validado = 1
    Todos = 2
End Enum

Public Enum enumTipoActualizacion
    Corregir
    Eliminar
End Enum

Public Enum enumTipoActualizacionPreciosObras
    PrecioCosteRecalcularPrecioVenta
    PrecioCosteRecalcularMargen
    PrecioVentaRecalcularMargen
    MargenRecalcularPrecioVenta
End Enum

Public Enum enumTipoAccionPreciosObras
    IncrementarDecrementarPrecio
    RecuperarPrecioCoste
    RecuperarPrecioVenta
    AplicarMargen
End Enum

Public Enum enumOrigenPedidoCompra
    Programa = 0
    OfertaComercial = 1
    Solicitud = 2
    Planificacion = 3
    Subcontratacion = 4
    Obras = 5
    OfertaCompra = 6
    Mnto = 7
    PedidoVenta = 8
    PedidoCompra = 9
End Enum

Public Enum enumOrigenAlbaranVenta
    Pedido
    Obras
    Alquiler
    AlbaranDistrib
End Enum

Public Enum enumFormatosEDI
    Expertis
    EDIExterno
End Enum

Public Enum enumFichEDIAgrup
    Albaranes = 0
    Facturas = 1
End Enum

Public Enum enumSituacionInmuebleCab
    SinDefinir = 0
    TerritorioEspañolNoComunidad = 1
    TerritorioComunidad = 2
    TerritorioSinReferencia = 3
    TerritorioExtranjero = 4
    Guipuzkoa = 5
    Alava = 6
    Bizkaia = 7
    Navarra = 8
End Enum

Public Enum enumFichPeriodoDeclaracion
    PorDeclaracion
    PorFecha
End Enum

Public Enum enumTipoRegistro
    TipoGrafico = 0
    TipoGrid = 1
End Enum

Public Enum enumUDMedidaNums
    Unidades = 1
    Millares = 1000
    Millones = 1000000
End Enum

Public Enum enumRHDiscapacidad
    Todos = -1
    ConDiscapacidad = 0
    SinDiscapacidad = 1
End Enum

Public Enum enumRHSexo
    Todos = -1
    Hombre = 0
    Mujer = 1
End Enum

Public Enum enumTipoControlCuadroMando
    TipoGrid = 0
    TipoGrafico = 1
    TipoReportService = 2
End Enum

Public Enum enumTipoPrecio
    PrecioConfigurado = 0
    PrecioEstandar = 1
End Enum

Public Enum enumGAIAProtocol
    DEFECTO = 0
    UBL20 = 1
    PDF_EMAIL = 3
    BULK_PARTIES = 4
    PREFERENCES = 5
    STATUS = 6
    Q43 = 7
End Enum

Public Enum enumGAIARole
    Invoice = 0
    Order = 1
    DeliveryNote = 2
End Enum

Public Enum enumGAIAEstadosDoc
    Unknown = 0
    NewNew = 1
    OpenNew = 2
    OpenDownloaded = 3
    ClosedAccepted = 4
    ClosedDeclined = 5
    ClosedModified = 6
    ClosedError = 7
    ClosedRejected = 8
End Enum

Public Enum enumGAIASecurityLevels
    Insecure = 0
    Signed = 1
    Encrypted = 2
    Signed_Verify = 3
    Encrypted_Verify = 4
End Enum

Public Enum enumGAIAModoFichero
    Descarga = 0
    Envio = 1
End Enum

Public Enum enumGAIAFormatoFichero
    PDF = 0
    Q43 = 1
    UBLXML = 2
End Enum

Public Enum enumTipoTarifa
    TarifaVenta = 0
    TarifaCompra = 1
End Enum

Public Enum enummcAgrupOT
    Cliente
    OT
End Enum

Public Enum enumTipoCuestionarioRM
    Normal
    Abreviado
    Pyme
    Mixto
End Enum

Public Enum enumTaxCode
    Exento = 0
    Superreducido = 1
    Reducido = 2
    General = 3
    Otros = 4
End Enum

Public Enum enumCodigoSaldo
    Cargo = 1
    Abono = 2
End Enum

Public Enum enumProcesados
    No
    Si
    Todos
End Enum

Public Enum enumContabilizado
    NoContabilizado = 0
    Contabilizado = 1
    ContabilizadoTributario = 2
    ContabilizadoNIIF = 3
End Enum

Public Enum enumContabilizadoTodos
    NoContabilizado = 0
    Contabilizado = 1
    ContabilizadoTributario = 2
    ContabilizadoNIIF = 3
    Todos = 4
End Enum

Public Enum enumEstadoAnticipo
    PdteAbono = 0
    Abonado = 1
    Cancelado = 2
End Enum

Public Enum enumGAIATipoEnvioCorreo
    LinkDescarga = 1
    DocAdjunto = 2
End Enum

Public Enum enumGAIATipoReenvioAviso
    ResendAndWarn = 0
    OnlyResend = 1
    OnlyWarn = 2
    None = 3
End Enum

Public Enum enumFactor
    Multiplica
    Divide
End Enum

Public Enum enumTipoCodigoEMCS
    TipoOrigen = 2
    REgimenFiscal = 3
    TipoDestino = 4
    TipoOrganizacionExenta = 5
    AutoridadCompetente = 6
    TipoCertificado = 7
    TipoFactura = 8
    CodigoAduana = 9
    UnidadFiscal = 10
    CodigosLenguaje = 12
    CodigoConclusionGlobalRecepcionInterno = 16
    AutoridadFiscal = 19
    TiposGarate = 29
    TiposOrigen = 30
    UnidadTransporte = 35
    CodigoProductoImpuestos = 36
    CategoriaProductoVino = 38
    ZonaDesarrolloVinicola = 40
    TiposEnvio = 71
    MediosTransporte = 97
    CodigoPais = 108
    CodigoConclusionGlobalRecepcion = 116
    TipoEmbalaje = 117
    CodigoCategoriaProductoVino = 138
    OperacionVino = 141
    CodigoRazonCancelacion = 143
    CodigoRazonInsatisfaccion = 146
    ModoTransporte = 167
    ResponsableTransporte = 170
    EpigrafeProducto = 201
    CodigoNomenclaturaCombinada = 202
    UnidadTransporteIntracomunitario = 350
    CodigosCAEExpedidor = 400
End Enum

Public Enum enumUnidadPerioricidadReparto
    Dia = 0
    Semana = 1
    Mes = 2
    Año = 3
End Enum
Public Enum AplicarSobre
    ComprasVentas
    Compras
    Ventas
End Enum

Public Enum PartidaOrigen
    FV = 0
    FC = 1
    Diario = 2
    PartesTrabajo = 3
    Gastos = 4
End Enum

Public Enum TipoPartida
    Cliente = 0
    Articulo = 1
End Enum

Public Enum RentabilidadPor
    Cliente = 0
    Articulo = 1
End Enum

Public Enum RentabilidadClasif
    Cliente = 0
    Articulo = 1
    Zona = 2
    Mercado = 3
    Pais = 4
    Tipo = 5
    Familia = 6
End Enum

Public Enum enumDetalleEntradaUva
    Cabecera = 0
    Cartillista = 1
    Finca = 2
End Enum

Public Enum EstadoAnalisis
    EnAnalisis = 0
    Terminado = 1
End Enum

Public Enum BdgClaseOperacion
    Prevista
    Real
End Enum

Public Enum enumottfCriterioGeneracion
    ImporteTrabajo = 0
    'DiferenciaConGenerados=1
    SobreUltimoImporteGenerado = 2
End Enum

Public Enum enumfcbiOrigen
    Compra
    Venta
End Enum
