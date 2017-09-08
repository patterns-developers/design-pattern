package org.com.designpattern.beans;

import org.com.designpattern.core.BeanBuildableType;

public class NF {

    private Identificacao identificacao;
    private Emitente emitente;
    private Destinatario destinatario;
    private Opicional opicional01;
    private Opicional opicional02;
    private Opicional opicional03;
    private Opicional opicional04;

    @Deprecated
    public NF(
        final Identificacao identificacao,
        final Emitente emitente,
        final Destinatario destinatario,
        final Opicional opicional01,
        final Opicional opicional02,
        final Opicional opicional03,
        final Opicional opicional04) {
        super();
        this.identificacao = identificacao;
        this.emitente = emitente;
        this.destinatario = destinatario;
        this.opicional01 = opicional01;
        this.opicional02 = opicional02;
        this.opicional03 = opicional03;
        this.opicional04 = opicional04;
    }

    @Deprecated
    public NF(
        final Identificacao identificacao,
        final Emitente emitente,
        final Destinatario destinatario) {
        super();
        this.identificacao = identificacao;
        this.emitente = emitente;
        this.destinatario = destinatario;
        opicional01 = null;
        opicional02 = null;
        opicional03 = null;
        opicional04 = null;
    }

    // FIXME
    NF() {
    }

    public NF(
        final BeanBuildableType<NF> builder) {
        NF bean = builder.getBean();
        identificacao = bean.identificacao;
        emitente = bean.emitente;
        destinatario = bean.destinatario;
        opicional01 = bean.opicional01;
        opicional02 = bean.opicional02;
        opicional03 = bean.opicional03;
        opicional04 = bean.opicional04;
    }

    public Identificacao getIdentificacao() {
        return identificacao;
    }

    public void setIdentificacao(
        final Identificacao identificacao) {
        this.identificacao = identificacao;
    }

    public Emitente getEmitente() {
        return emitente;
    }

    public void setEmitente(
        final Emitente emitente) {
        this.emitente = emitente;
    }

    public Destinatario getDestinatario() {
        return destinatario;
    }

    public void setDestinatario(
        final Destinatario destinatario) {
        this.destinatario = destinatario;
    }

    public Opicional getOpicional01() {
        return opicional01;
    }

    public void setOpicional01(
        final Opicional opicional01) {
        this.opicional01 = opicional01;
    }

    public Opicional getOpicional02() {
        return opicional02;
    }

    public void setOpicional02(
        final Opicional opicional02) {
        this.opicional02 = opicional02;
    }

    public Opicional getOpicional03() {
        return opicional03;
    }

    public void setOpicional03(
        final Opicional opicional03) {
        this.opicional03 = opicional03;
    }

    public Opicional getOpicional04() {
        return opicional04;
    }

    public void setOpicional04(
        final Opicional opicional04) {
        this.opicional04 = opicional04;
    }
}
