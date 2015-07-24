
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 07/16/2015 18:44:53
-- Generated from EDMX file: C:\Users\feevale\Desktop\Kanban_Manager\Kanban\ModelKanban.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [KANBAN];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__grupo_usu__id_fa__10566F31]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[grupo_usuarios_x_fases] DROP CONSTRAINT [FK__grupo_usu__id_fa__10566F31];
GO
IF OBJECT_ID(N'[dbo].[FK__grupo_usu__id_gr__05D8E0BE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[grupo_usuario_x_permissao] DROP CONSTRAINT [FK__grupo_usu__id_gr__05D8E0BE];
GO
IF OBJECT_ID(N'[dbo].[FK__grupo_usu__id_gr__0F624AF8]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[grupo_usuarios_x_fases] DROP CONSTRAINT [FK__grupo_usu__id_gr__0F624AF8];
GO
IF OBJECT_ID(N'[dbo].[FK__grupo_usu__id_gr__6B24EA82]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[grupo_usuario_x_permissao] DROP CONSTRAINT [FK__grupo_usu__id_gr__6B24EA82];
GO
IF OBJECT_ID(N'[dbo].[FK__grupo_usu__id_pe__04E4BC85]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[grupo_usuario_x_permissao] DROP CONSTRAINT [FK__grupo_usu__id_pe__04E4BC85];
GO
IF OBJECT_ID(N'[dbo].[FK__grupo_usu__id_pe__6A30C649]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[grupo_usuario_x_permissao] DROP CONSTRAINT [FK__grupo_usu__id_pe__6A30C649];
GO
IF OBJECT_ID(N'[dbo].[FK__grupo_usu__id_us__03F0984C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[grupo_usuarios] DROP CONSTRAINT [FK__grupo_usu__id_us__03F0984C];
GO
IF OBJECT_ID(N'[dbo].[FK__grupo_usu__id_us__693CA210]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[grupo_usuarios] DROP CONSTRAINT [FK__grupo_usu__id_us__693CA210];
GO
IF OBJECT_ID(N'[dbo].[FK__projeto_x__id_pr__06CD04F7]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[projeto_x_usuario] DROP CONSTRAINT [FK__projeto_x__id_pr__06CD04F7];
GO
IF OBJECT_ID(N'[dbo].[FK__projeto_x__id_pr__6C190EBB]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[projeto_x_usuario] DROP CONSTRAINT [FK__projeto_x__id_pr__6C190EBB];
GO
IF OBJECT_ID(N'[dbo].[FK__projeto_x__id_us__07C12930]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[projeto_x_usuario] DROP CONSTRAINT [FK__projeto_x__id_us__07C12930];
GO
IF OBJECT_ID(N'[dbo].[FK__projeto_x__id_us__6D0D32F4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[projeto_x_usuario] DROP CONSTRAINT [FK__projeto_x__id_us__6D0D32F4];
GO
IF OBJECT_ID(N'[dbo].[FK__sprints__id_spri__5EBF139D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[sprints] DROP CONSTRAINT [FK__sprints__id_spri__5EBF139D];
GO
IF OBJECT_ID(N'[dbo].[FK__sprints__id_spri__797309D9]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[sprints] DROP CONSTRAINT [FK__sprints__id_spri__797309D9];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefa_x___id_gr__0C85DE4D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefa_x_usuario] DROP CONSTRAINT [FK__tarefa_x___id_gr__0C85DE4D];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefa_x___id_ta__08B54D69]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefa_x_comentario] DROP CONSTRAINT [FK__tarefa_x___id_ta__08B54D69];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefa_x___id_ta__0A9D95DB]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefa_x_usuario] DROP CONSTRAINT [FK__tarefa_x___id_ta__0A9D95DB];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefa_x___id_ta__6E01572D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefa_x_comentario] DROP CONSTRAINT [FK__tarefa_x___id_ta__6E01572D];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefa_x___id_us__09A971A2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefa_x_usuario] DROP CONSTRAINT [FK__tarefa_x___id_us__09A971A2];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefa_x___id_us__0B91BA14]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefa_x_usuario] DROP CONSTRAINT [FK__tarefa_x___id_us__0B91BA14];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_clas__00200768]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_clas__00200768];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_clas__656C112C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_clas__656C112C];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_grup__628FA481]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_grup__628FA481];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_grup__7D439ABD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_grup__7D439ABD];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_proj__60A75C0F]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_proj__60A75C0F];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_proj__7B5B524B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_proj__7B5B524B];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_spri__5FB337D6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_spri__5FB337D6];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_spri__7A672E12]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_spri__7A672E12];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_stat__619B8048]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_stat__619B8048];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_stat__7C4F7684]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_stat__7C4F7684];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_tare__01142BA1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_tare__01142BA1];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_tare__02084FDA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_tare__02084FDA];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_tare__66603565]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_tare__66603565];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_tare__6754599E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_tare__6754599E];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_tipo__6477ECF3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_tipo__6477ECF3];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_tipo__7F2BE32F]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_tipo__7F2BE32F];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_usua__6383C8BA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_usua__6383C8BA];
GO
IF OBJECT_ID(N'[dbo].[FK__tarefas__id_usua__7E37BEF6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tarefas] DROP CONSTRAINT [FK__tarefas__id_usua__7E37BEF6];
GO
IF OBJECT_ID(N'[dbo].[FK__usuario__id_avat__02FC7413]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK__usuario__id_avat__02FC7413];
GO
IF OBJECT_ID(N'[dbo].[FK__usuario__id_avat__68487DD7]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK__usuario__id_avat__68487DD7];
GO
IF OBJECT_ID(N'[dbo].[FK__usuario_x__id_gr__0D7A0286]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[usuario_x_grupos_usuario] DROP CONSTRAINT [FK__usuario_x__id_gr__0D7A0286];
GO
IF OBJECT_ID(N'[dbo].[FK__usuario_x__id_us__0E6E26BF]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[usuario_x_grupos_usuario] DROP CONSTRAINT [FK__usuario_x__id_us__0E6E26BF];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[avatar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[avatar];
GO
IF OBJECT_ID(N'[dbo].[classificacao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[classificacao];
GO
IF OBJECT_ID(N'[dbo].[fases]', 'U') IS NOT NULL
    DROP TABLE [dbo].[fases];
GO
IF OBJECT_ID(N'[dbo].[grupo_usuario_x_permissao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[grupo_usuario_x_permissao];
GO
IF OBJECT_ID(N'[dbo].[grupo_usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[grupo_usuarios];
GO
IF OBJECT_ID(N'[dbo].[grupo_usuarios_x_fases]', 'U') IS NOT NULL
    DROP TABLE [dbo].[grupo_usuarios_x_fases];
GO
IF OBJECT_ID(N'[dbo].[permissao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[permissao];
GO
IF OBJECT_ID(N'[dbo].[projeto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[projeto];
GO
IF OBJECT_ID(N'[dbo].[projeto_x_usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[projeto_x_usuario];
GO
IF OBJECT_ID(N'[dbo].[sprints]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sprints];
GO
IF OBJECT_ID(N'[dbo].[status]', 'U') IS NOT NULL
    DROP TABLE [dbo].[status];
GO
IF OBJECT_ID(N'[dbo].[tarefa_x_comentario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tarefa_x_comentario];
GO
IF OBJECT_ID(N'[dbo].[tarefa_x_usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tarefa_x_usuario];
GO
IF OBJECT_ID(N'[dbo].[tarefas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tarefas];
GO
IF OBJECT_ID(N'[dbo].[tipo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tipo];
GO
IF OBJECT_ID(N'[dbo].[usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[usuario];
GO
IF OBJECT_ID(N'[dbo].[usuario_x_grupos_usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[usuario_x_grupos_usuario];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'avatar'
CREATE TABLE [dbo].[avatar] (
    [id] int IDENTITY(1,1) NOT NULL,
    [path_avatar] varchar(200)  NULL
);
GO

-- Creating table 'classificacao'
CREATE TABLE [dbo].[classificacao] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descricao] varchar(80)  NOT NULL,
    [ativo] bit  NOT NULL
);
GO

-- Creating table 'fases'
CREATE TABLE [dbo].[fases] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descricao] varchar(80)  NOT NULL,
    [ativo] bit  NOT NULL
);
GO

-- Creating table 'grupo_usuario_x_permissao'
CREATE TABLE [dbo].[grupo_usuario_x_permissao] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_permissao] int  NULL,
    [id_grupo_usuario] int  NULL
);
GO

-- Creating table 'grupo_usuarios'
CREATE TABLE [dbo].[grupo_usuarios] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descricao] varchar(80)  NOT NULL,
    [cor_grupo] varchar(20)  NOT NULL,
    [id_usuario_lider] int  NOT NULL,
    [ativo] bit  NOT NULL
);
GO

-- Creating table 'grupo_usuarios_x_fases'
CREATE TABLE [dbo].[grupo_usuarios_x_fases] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_grupo_usuarios] int  NOT NULL,
    [id_fases] int  NOT NULL
);
GO

-- Creating table 'permissao'
CREATE TABLE [dbo].[permissao] (
    [id] int IDENTITY(1,1) NOT NULL,
    [titulo] varchar(50)  NOT NULL
);
GO

-- Creating table 'projeto'
CREATE TABLE [dbo].[projeto] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descricao] varchar(500)  NULL,
    [titulo] varchar(50)  NOT NULL
);
GO

-- Creating table 'projeto_x_usuario'
CREATE TABLE [dbo].[projeto_x_usuario] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_projeto] int  NOT NULL,
    [id_usuario] int  NOT NULL
);
GO

-- Creating table 'sprints'
CREATE TABLE [dbo].[sprints] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_sprints_dependencia] int  NULL,
    [descricao] varchar(50)  NOT NULL,
    [dt_inicio] datetime  NULL,
    [dt_fim] datetime  NULL,
    [ativo] bit  NULL,
    [dt_finalizacao] datetime  NULL
);
GO

-- Creating table 'status'
CREATE TABLE [dbo].[status] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descricao] varchar(50)  NOT NULL
);
GO

-- Creating table 'tarefa_x_comentario'
CREATE TABLE [dbo].[tarefa_x_comentario] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_tarefas] int  NOT NULL,
    [dt_comentário] datetime  NULL,
    [descricao] varchar(500)  NULL,
    [anexo] varchar(200)  NULL
);
GO

-- Creating table 'tarefa_x_usuario'
CREATE TABLE [dbo].[tarefa_x_usuario] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_usuario] int  NULL,
    [id_tarefas] int  NULL,
    [ativo] bit  NULL,
    [id_usuario_proximo] int  NULL,
    [dt_criacao] datetime  NULL,
    [id_grupo_usuarios_proximo] int  NULL,
    [indice] int  NULL,
    [dt_inicio_tarefa] datetime  NULL,
    [dt_fim_tarefa] datetime  NULL
);
GO

-- Creating table 'tarefas'
CREATE TABLE [dbo].[tarefas] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_sprints] int  NULL,
    [id_projeto] int  NOT NULL,
    [descricao] varchar(200)  NULL,
    [id_status] int  NULL,
    [id_grupo_usuarios_x_fases] int  NULL,
    [indice] int  NOT NULL,
    [id_usuario_creator] int  NOT NULL,
    [tempo_estimado] time  NULL,
    [tempo_trabalhado] time  NULL,
    [id_tipo] int  NOT NULL,
    [id_classificacao] int  NULL,
    [tarefa_planejada] bit  NULL,
    [id_tarefa_dependencia] int  NULL,
    [dt_criacao] datetime  NOT NULL,
    [id_tarefa_agrupador] int  NULL
);
GO

-- Creating table 'tipo'
CREATE TABLE [dbo].[tipo] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descricao] varchar(50)  NOT NULL
);
GO

-- Creating table 'usuario'
CREATE TABLE [dbo].[usuario] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_avatar] int  NULL,
    [nome_usuario] varchar(80)  NOT NULL,
    [login] varchar(100)  NOT NULL,
    [senha] varchar(20)  NOT NULL
);
GO

-- Creating table 'usuario_x_grupos_usuario'
CREATE TABLE [dbo].[usuario_x_grupos_usuario] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_grupos_usuario] int  NULL,
    [id_usuario] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'avatar'
ALTER TABLE [dbo].[avatar]
ADD CONSTRAINT [PK_avatar]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'classificacao'
ALTER TABLE [dbo].[classificacao]
ADD CONSTRAINT [PK_classificacao]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'fases'
ALTER TABLE [dbo].[fases]
ADD CONSTRAINT [PK_fases]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'grupo_usuario_x_permissao'
ALTER TABLE [dbo].[grupo_usuario_x_permissao]
ADD CONSTRAINT [PK_grupo_usuario_x_permissao]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'grupo_usuarios'
ALTER TABLE [dbo].[grupo_usuarios]
ADD CONSTRAINT [PK_grupo_usuarios]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'grupo_usuarios_x_fases'
ALTER TABLE [dbo].[grupo_usuarios_x_fases]
ADD CONSTRAINT [PK_grupo_usuarios_x_fases]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'permissao'
ALTER TABLE [dbo].[permissao]
ADD CONSTRAINT [PK_permissao]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'projeto'
ALTER TABLE [dbo].[projeto]
ADD CONSTRAINT [PK_projeto]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'projeto_x_usuario'
ALTER TABLE [dbo].[projeto_x_usuario]
ADD CONSTRAINT [PK_projeto_x_usuario]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'sprints'
ALTER TABLE [dbo].[sprints]
ADD CONSTRAINT [PK_sprints]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'status'
ALTER TABLE [dbo].[status]
ADD CONSTRAINT [PK_status]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tarefa_x_comentario'
ALTER TABLE [dbo].[tarefa_x_comentario]
ADD CONSTRAINT [PK_tarefa_x_comentario]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tarefa_x_usuario'
ALTER TABLE [dbo].[tarefa_x_usuario]
ADD CONSTRAINT [PK_tarefa_x_usuario]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [PK_tarefas]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tipo'
ALTER TABLE [dbo].[tipo]
ADD CONSTRAINT [PK_tipo]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'usuario'
ALTER TABLE [dbo].[usuario]
ADD CONSTRAINT [PK_usuario]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'usuario_x_grupos_usuario'
ALTER TABLE [dbo].[usuario_x_grupos_usuario]
ADD CONSTRAINT [PK_usuario_x_grupos_usuario]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [id_avatar] in table 'usuario'
ALTER TABLE [dbo].[usuario]
ADD CONSTRAINT [FK__usuario__id_avat__02FC7413]
    FOREIGN KEY ([id_avatar])
    REFERENCES [dbo].[avatar]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__usuario__id_avat__02FC7413'
CREATE INDEX [IX_FK__usuario__id_avat__02FC7413]
ON [dbo].[usuario]
    ([id_avatar]);
GO

-- Creating foreign key on [id_avatar] in table 'usuario'
ALTER TABLE [dbo].[usuario]
ADD CONSTRAINT [FK__usuario__id_avat__68487DD7]
    FOREIGN KEY ([id_avatar])
    REFERENCES [dbo].[avatar]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__usuario__id_avat__68487DD7'
CREATE INDEX [IX_FK__usuario__id_avat__68487DD7]
ON [dbo].[usuario]
    ([id_avatar]);
GO

-- Creating foreign key on [id_classificacao] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_clas__00200768]
    FOREIGN KEY ([id_classificacao])
    REFERENCES [dbo].[classificacao]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_clas__00200768'
CREATE INDEX [IX_FK__tarefas__id_clas__00200768]
ON [dbo].[tarefas]
    ([id_classificacao]);
GO

-- Creating foreign key on [id_classificacao] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_clas__656C112C]
    FOREIGN KEY ([id_classificacao])
    REFERENCES [dbo].[classificacao]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_clas__656C112C'
CREATE INDEX [IX_FK__tarefas__id_clas__656C112C]
ON [dbo].[tarefas]
    ([id_classificacao]);
GO

-- Creating foreign key on [id_fases] in table 'grupo_usuarios_x_fases'
ALTER TABLE [dbo].[grupo_usuarios_x_fases]
ADD CONSTRAINT [FK__grupo_usu__id_fa__10566F31]
    FOREIGN KEY ([id_fases])
    REFERENCES [dbo].[fases]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__grupo_usu__id_fa__10566F31'
CREATE INDEX [IX_FK__grupo_usu__id_fa__10566F31]
ON [dbo].[grupo_usuarios_x_fases]
    ([id_fases]);
GO

-- Creating foreign key on [id_grupo_usuario] in table 'grupo_usuario_x_permissao'
ALTER TABLE [dbo].[grupo_usuario_x_permissao]
ADD CONSTRAINT [FK__grupo_usu__id_gr__05D8E0BE]
    FOREIGN KEY ([id_grupo_usuario])
    REFERENCES [dbo].[grupo_usuarios]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__grupo_usu__id_gr__05D8E0BE'
CREATE INDEX [IX_FK__grupo_usu__id_gr__05D8E0BE]
ON [dbo].[grupo_usuario_x_permissao]
    ([id_grupo_usuario]);
GO

-- Creating foreign key on [id_grupo_usuario] in table 'grupo_usuario_x_permissao'
ALTER TABLE [dbo].[grupo_usuario_x_permissao]
ADD CONSTRAINT [FK__grupo_usu__id_gr__6B24EA82]
    FOREIGN KEY ([id_grupo_usuario])
    REFERENCES [dbo].[grupo_usuarios]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__grupo_usu__id_gr__6B24EA82'
CREATE INDEX [IX_FK__grupo_usu__id_gr__6B24EA82]
ON [dbo].[grupo_usuario_x_permissao]
    ([id_grupo_usuario]);
GO

-- Creating foreign key on [id_permissao] in table 'grupo_usuario_x_permissao'
ALTER TABLE [dbo].[grupo_usuario_x_permissao]
ADD CONSTRAINT [FK__grupo_usu__id_pe__04E4BC85]
    FOREIGN KEY ([id_permissao])
    REFERENCES [dbo].[permissao]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__grupo_usu__id_pe__04E4BC85'
CREATE INDEX [IX_FK__grupo_usu__id_pe__04E4BC85]
ON [dbo].[grupo_usuario_x_permissao]
    ([id_permissao]);
GO

-- Creating foreign key on [id_permissao] in table 'grupo_usuario_x_permissao'
ALTER TABLE [dbo].[grupo_usuario_x_permissao]
ADD CONSTRAINT [FK__grupo_usu__id_pe__6A30C649]
    FOREIGN KEY ([id_permissao])
    REFERENCES [dbo].[permissao]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__grupo_usu__id_pe__6A30C649'
CREATE INDEX [IX_FK__grupo_usu__id_pe__6A30C649]
ON [dbo].[grupo_usuario_x_permissao]
    ([id_permissao]);
GO

-- Creating foreign key on [id_grupo_usuarios] in table 'grupo_usuarios_x_fases'
ALTER TABLE [dbo].[grupo_usuarios_x_fases]
ADD CONSTRAINT [FK__grupo_usu__id_gr__0F624AF8]
    FOREIGN KEY ([id_grupo_usuarios])
    REFERENCES [dbo].[grupo_usuarios]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__grupo_usu__id_gr__0F624AF8'
CREATE INDEX [IX_FK__grupo_usu__id_gr__0F624AF8]
ON [dbo].[grupo_usuarios_x_fases]
    ([id_grupo_usuarios]);
GO

-- Creating foreign key on [id_usuario_lider] in table 'grupo_usuarios'
ALTER TABLE [dbo].[grupo_usuarios]
ADD CONSTRAINT [FK__grupo_usu__id_us__03F0984C]
    FOREIGN KEY ([id_usuario_lider])
    REFERENCES [dbo].[usuario]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__grupo_usu__id_us__03F0984C'
CREATE INDEX [IX_FK__grupo_usu__id_us__03F0984C]
ON [dbo].[grupo_usuarios]
    ([id_usuario_lider]);
GO

-- Creating foreign key on [id_usuario_lider] in table 'grupo_usuarios'
ALTER TABLE [dbo].[grupo_usuarios]
ADD CONSTRAINT [FK__grupo_usu__id_us__693CA210]
    FOREIGN KEY ([id_usuario_lider])
    REFERENCES [dbo].[usuario]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__grupo_usu__id_us__693CA210'
CREATE INDEX [IX_FK__grupo_usu__id_us__693CA210]
ON [dbo].[grupo_usuarios]
    ([id_usuario_lider]);
GO

-- Creating foreign key on [id_grupo_usuarios_proximo] in table 'tarefa_x_usuario'
ALTER TABLE [dbo].[tarefa_x_usuario]
ADD CONSTRAINT [FK__tarefa_x___id_gr__0C85DE4D]
    FOREIGN KEY ([id_grupo_usuarios_proximo])
    REFERENCES [dbo].[grupo_usuarios]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefa_x___id_gr__0C85DE4D'
CREATE INDEX [IX_FK__tarefa_x___id_gr__0C85DE4D]
ON [dbo].[tarefa_x_usuario]
    ([id_grupo_usuarios_proximo]);
GO

-- Creating foreign key on [id_grupos_usuario] in table 'usuario_x_grupos_usuario'
ALTER TABLE [dbo].[usuario_x_grupos_usuario]
ADD CONSTRAINT [FK__usuario_x__id_gr__0D7A0286]
    FOREIGN KEY ([id_grupos_usuario])
    REFERENCES [dbo].[grupo_usuarios]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__usuario_x__id_gr__0D7A0286'
CREATE INDEX [IX_FK__usuario_x__id_gr__0D7A0286]
ON [dbo].[usuario_x_grupos_usuario]
    ([id_grupos_usuario]);
GO

-- Creating foreign key on [id_grupo_usuarios_x_fases] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_grup__628FA481]
    FOREIGN KEY ([id_grupo_usuarios_x_fases])
    REFERENCES [dbo].[grupo_usuarios_x_fases]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_grup__628FA481'
CREATE INDEX [IX_FK__tarefas__id_grup__628FA481]
ON [dbo].[tarefas]
    ([id_grupo_usuarios_x_fases]);
GO

-- Creating foreign key on [id_grupo_usuarios_x_fases] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_grup__7D439ABD]
    FOREIGN KEY ([id_grupo_usuarios_x_fases])
    REFERENCES [dbo].[grupo_usuarios_x_fases]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_grup__7D439ABD'
CREATE INDEX [IX_FK__tarefas__id_grup__7D439ABD]
ON [dbo].[tarefas]
    ([id_grupo_usuarios_x_fases]);
GO

-- Creating foreign key on [id_projeto] in table 'projeto_x_usuario'
ALTER TABLE [dbo].[projeto_x_usuario]
ADD CONSTRAINT [FK__projeto_x__id_pr__06CD04F7]
    FOREIGN KEY ([id_projeto])
    REFERENCES [dbo].[projeto]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__projeto_x__id_pr__06CD04F7'
CREATE INDEX [IX_FK__projeto_x__id_pr__06CD04F7]
ON [dbo].[projeto_x_usuario]
    ([id_projeto]);
GO

-- Creating foreign key on [id_projeto] in table 'projeto_x_usuario'
ALTER TABLE [dbo].[projeto_x_usuario]
ADD CONSTRAINT [FK__projeto_x__id_pr__6C190EBB]
    FOREIGN KEY ([id_projeto])
    REFERENCES [dbo].[projeto]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__projeto_x__id_pr__6C190EBB'
CREATE INDEX [IX_FK__projeto_x__id_pr__6C190EBB]
ON [dbo].[projeto_x_usuario]
    ([id_projeto]);
GO

-- Creating foreign key on [id_projeto] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_proj__60A75C0F]
    FOREIGN KEY ([id_projeto])
    REFERENCES [dbo].[projeto]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_proj__60A75C0F'
CREATE INDEX [IX_FK__tarefas__id_proj__60A75C0F]
ON [dbo].[tarefas]
    ([id_projeto]);
GO

-- Creating foreign key on [id_projeto] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_proj__7B5B524B]
    FOREIGN KEY ([id_projeto])
    REFERENCES [dbo].[projeto]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_proj__7B5B524B'
CREATE INDEX [IX_FK__tarefas__id_proj__7B5B524B]
ON [dbo].[tarefas]
    ([id_projeto]);
GO

-- Creating foreign key on [id_usuario] in table 'projeto_x_usuario'
ALTER TABLE [dbo].[projeto_x_usuario]
ADD CONSTRAINT [FK__projeto_x__id_us__07C12930]
    FOREIGN KEY ([id_usuario])
    REFERENCES [dbo].[usuario]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__projeto_x__id_us__07C12930'
CREATE INDEX [IX_FK__projeto_x__id_us__07C12930]
ON [dbo].[projeto_x_usuario]
    ([id_usuario]);
GO

-- Creating foreign key on [id_usuario] in table 'projeto_x_usuario'
ALTER TABLE [dbo].[projeto_x_usuario]
ADD CONSTRAINT [FK__projeto_x__id_us__6D0D32F4]
    FOREIGN KEY ([id_usuario])
    REFERENCES [dbo].[usuario]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__projeto_x__id_us__6D0D32F4'
CREATE INDEX [IX_FK__projeto_x__id_us__6D0D32F4]
ON [dbo].[projeto_x_usuario]
    ([id_usuario]);
GO

-- Creating foreign key on [id_sprints_dependencia] in table 'sprints'
ALTER TABLE [dbo].[sprints]
ADD CONSTRAINT [FK__sprints__id_spri__5EBF139D]
    FOREIGN KEY ([id_sprints_dependencia])
    REFERENCES [dbo].[sprints]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__sprints__id_spri__5EBF139D'
CREATE INDEX [IX_FK__sprints__id_spri__5EBF139D]
ON [dbo].[sprints]
    ([id_sprints_dependencia]);
GO

-- Creating foreign key on [id_sprints_dependencia] in table 'sprints'
ALTER TABLE [dbo].[sprints]
ADD CONSTRAINT [FK__sprints__id_spri__797309D9]
    FOREIGN KEY ([id_sprints_dependencia])
    REFERENCES [dbo].[sprints]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__sprints__id_spri__797309D9'
CREATE INDEX [IX_FK__sprints__id_spri__797309D9]
ON [dbo].[sprints]
    ([id_sprints_dependencia]);
GO

-- Creating foreign key on [id_sprints] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_spri__5FB337D6]
    FOREIGN KEY ([id_sprints])
    REFERENCES [dbo].[sprints]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_spri__5FB337D6'
CREATE INDEX [IX_FK__tarefas__id_spri__5FB337D6]
ON [dbo].[tarefas]
    ([id_sprints]);
GO

-- Creating foreign key on [id_sprints] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_spri__7A672E12]
    FOREIGN KEY ([id_sprints])
    REFERENCES [dbo].[sprints]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_spri__7A672E12'
CREATE INDEX [IX_FK__tarefas__id_spri__7A672E12]
ON [dbo].[tarefas]
    ([id_sprints]);
GO

-- Creating foreign key on [id_status] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_stat__619B8048]
    FOREIGN KEY ([id_status])
    REFERENCES [dbo].[status]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_stat__619B8048'
CREATE INDEX [IX_FK__tarefas__id_stat__619B8048]
ON [dbo].[tarefas]
    ([id_status]);
GO

-- Creating foreign key on [id_status] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_stat__7C4F7684]
    FOREIGN KEY ([id_status])
    REFERENCES [dbo].[status]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_stat__7C4F7684'
CREATE INDEX [IX_FK__tarefas__id_stat__7C4F7684]
ON [dbo].[tarefas]
    ([id_status]);
GO

-- Creating foreign key on [id_tarefas] in table 'tarefa_x_comentario'
ALTER TABLE [dbo].[tarefa_x_comentario]
ADD CONSTRAINT [FK__tarefa_x___id_ta__08B54D69]
    FOREIGN KEY ([id_tarefas])
    REFERENCES [dbo].[tarefas]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefa_x___id_ta__08B54D69'
CREATE INDEX [IX_FK__tarefa_x___id_ta__08B54D69]
ON [dbo].[tarefa_x_comentario]
    ([id_tarefas]);
GO

-- Creating foreign key on [id_tarefas] in table 'tarefa_x_comentario'
ALTER TABLE [dbo].[tarefa_x_comentario]
ADD CONSTRAINT [FK__tarefa_x___id_ta__6E01572D]
    FOREIGN KEY ([id_tarefas])
    REFERENCES [dbo].[tarefas]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefa_x___id_ta__6E01572D'
CREATE INDEX [IX_FK__tarefa_x___id_ta__6E01572D]
ON [dbo].[tarefa_x_comentario]
    ([id_tarefas]);
GO

-- Creating foreign key on [id_tarefas] in table 'tarefa_x_usuario'
ALTER TABLE [dbo].[tarefa_x_usuario]
ADD CONSTRAINT [FK__tarefa_x___id_ta__0A9D95DB]
    FOREIGN KEY ([id_tarefas])
    REFERENCES [dbo].[tarefas]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefa_x___id_ta__0A9D95DB'
CREATE INDEX [IX_FK__tarefa_x___id_ta__0A9D95DB]
ON [dbo].[tarefa_x_usuario]
    ([id_tarefas]);
GO

-- Creating foreign key on [id_usuario] in table 'tarefa_x_usuario'
ALTER TABLE [dbo].[tarefa_x_usuario]
ADD CONSTRAINT [FK__tarefa_x___id_us__09A971A2]
    FOREIGN KEY ([id_usuario])
    REFERENCES [dbo].[usuario]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefa_x___id_us__09A971A2'
CREATE INDEX [IX_FK__tarefa_x___id_us__09A971A2]
ON [dbo].[tarefa_x_usuario]
    ([id_usuario]);
GO

-- Creating foreign key on [id_usuario_proximo] in table 'tarefa_x_usuario'
ALTER TABLE [dbo].[tarefa_x_usuario]
ADD CONSTRAINT [FK__tarefa_x___id_us__0B91BA14]
    FOREIGN KEY ([id_usuario_proximo])
    REFERENCES [dbo].[usuario]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefa_x___id_us__0B91BA14'
CREATE INDEX [IX_FK__tarefa_x___id_us__0B91BA14]
ON [dbo].[tarefa_x_usuario]
    ([id_usuario_proximo]);
GO

-- Creating foreign key on [id_tarefa_dependencia] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_tare__01142BA1]
    FOREIGN KEY ([id_tarefa_dependencia])
    REFERENCES [dbo].[tarefas]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_tare__01142BA1'
CREATE INDEX [IX_FK__tarefas__id_tare__01142BA1]
ON [dbo].[tarefas]
    ([id_tarefa_dependencia]);
GO

-- Creating foreign key on [id_tarefa_agrupador] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_tare__02084FDA]
    FOREIGN KEY ([id_tarefa_agrupador])
    REFERENCES [dbo].[tarefas]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_tare__02084FDA'
CREATE INDEX [IX_FK__tarefas__id_tare__02084FDA]
ON [dbo].[tarefas]
    ([id_tarefa_agrupador]);
GO

-- Creating foreign key on [id_tarefa_dependencia] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_tare__66603565]
    FOREIGN KEY ([id_tarefa_dependencia])
    REFERENCES [dbo].[tarefas]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_tare__66603565'
CREATE INDEX [IX_FK__tarefas__id_tare__66603565]
ON [dbo].[tarefas]
    ([id_tarefa_dependencia]);
GO

-- Creating foreign key on [id_tarefa_agrupador] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_tare__6754599E]
    FOREIGN KEY ([id_tarefa_agrupador])
    REFERENCES [dbo].[tarefas]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_tare__6754599E'
CREATE INDEX [IX_FK__tarefas__id_tare__6754599E]
ON [dbo].[tarefas]
    ([id_tarefa_agrupador]);
GO

-- Creating foreign key on [id_tipo] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_tipo__6477ECF3]
    FOREIGN KEY ([id_tipo])
    REFERENCES [dbo].[tipo]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_tipo__6477ECF3'
CREATE INDEX [IX_FK__tarefas__id_tipo__6477ECF3]
ON [dbo].[tarefas]
    ([id_tipo]);
GO

-- Creating foreign key on [id_tipo] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_tipo__7F2BE32F]
    FOREIGN KEY ([id_tipo])
    REFERENCES [dbo].[tipo]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_tipo__7F2BE32F'
CREATE INDEX [IX_FK__tarefas__id_tipo__7F2BE32F]
ON [dbo].[tarefas]
    ([id_tipo]);
GO

-- Creating foreign key on [id_usuario_creator] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_usua__6383C8BA]
    FOREIGN KEY ([id_usuario_creator])
    REFERENCES [dbo].[usuario]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_usua__6383C8BA'
CREATE INDEX [IX_FK__tarefas__id_usua__6383C8BA]
ON [dbo].[tarefas]
    ([id_usuario_creator]);
GO

-- Creating foreign key on [id_usuario_creator] in table 'tarefas'
ALTER TABLE [dbo].[tarefas]
ADD CONSTRAINT [FK__tarefas__id_usua__7E37BEF6]
    FOREIGN KEY ([id_usuario_creator])
    REFERENCES [dbo].[usuario]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__tarefas__id_usua__7E37BEF6'
CREATE INDEX [IX_FK__tarefas__id_usua__7E37BEF6]
ON [dbo].[tarefas]
    ([id_usuario_creator]);
GO

-- Creating foreign key on [id_usuario] in table 'usuario_x_grupos_usuario'
ALTER TABLE [dbo].[usuario_x_grupos_usuario]
ADD CONSTRAINT [FK__usuario_x__id_us__0E6E26BF]
    FOREIGN KEY ([id_usuario])
    REFERENCES [dbo].[usuario]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__usuario_x__id_us__0E6E26BF'
CREATE INDEX [IX_FK__usuario_x__id_us__0E6E26BF]
ON [dbo].[usuario_x_grupos_usuario]
    ([id_usuario]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------