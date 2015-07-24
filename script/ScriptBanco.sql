-- ---
-- Globals
-- ---
 
-- SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
-- SET FOREIGN_KEY_CHECKS=0;
 
-- ---
-- Table 'projeto'
-- 
-- ---
--CREATE DATABASE KANBAN

     
CREATE TABLE projeto (
  id INT IDENTITY(1,1) NOT NULL,
  descricao VARCHAR NULL DEFAULT NULL,
  PRIMARY KEY (id)
);
 
-- ---
-- Table 'sprints'
-- 
-- ---
 
     
CREATE TABLE sprints (
  id INT IDENTITY(1,1) NOT NULL,
  id_sprints_dependencia INT NULL DEFAULT NULL,
  descricao VARCHAR NULL DEFAULT NULL,
  dt_inicio DATETIME NULL DEFAULT NULL,
  dt_fim DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (id)
);
 
-- ---
-- Table 'tarefas'
-- 
-- ---
CREATE TABLE tarefas (
  id INT IDENTITY(1,1) NOT NULL,
  id_sprints INT NULL DEFAULT NULL,
  id_projeto INT NULL DEFAULT NULL,
  descricao VARCHAR NULL DEFAULT NULL,
  id_status INT NULL DEFAULT NULL,
  id_grupo_usuarios_x_fases INT NULL DEFAULT NULL,
  indice INT NULL DEFAULT NULL,
  id_usuario_creator INT NULL DEFAULT NULL,
  tempo_estimado TIME NULL DEFAULT NULL,
  tempo_trabalhado TIME NULL DEFAULT NULL,
  id_tipo INT NULL DEFAULT NULL,
  id_classificacao INT NULL DEFAULT NULL,
  tarefa_planejada bit NULL DEFAULT NULL ,
  id_tarefa_dependencia INT NULL DEFAULT NULL,
  dt_criacao DATETIME NULL DEFAULT NULL,
  id_tarefa_agrupador INT NULL DEFAULT NULL,
  PRIMARY KEY (id)
);
 
-- ---
-- Table 'fases'
-- To Do, Doing, Done
-- ---
 
CREATE TABLE fases (
  id INT IDENTITY(1,1) NOT NULL,
  descricao VARCHAR NULL DEFAULT NULL,
  ativo bit NULL DEFAULT NULL,
  PRIMARY KEY (id)
) --COMMENT 'To Do, Doing, Done';
 
-- ---
-- Table 'usuario'
-- 
-- ---
 
CREATE TABLE usuario (
  id INT IDENTITY(1,1) NOT NULL,
  id_avatar INT NULL DEFAULT NULL,
  descricao VARCHAR NULL DEFAULT NULL,
  nome_usuario VARCHAR NULL DEFAULT NULL,
  login VARCHAR NULL DEFAULT NULL,
  senha VARCHAR NULL DEFAULT NULL,
  PRIMARY KEY (id)
);
 
-- ---
-- Table 'grupo_usuarios'
-- Admin, Desenvolvedor, Tester
-- ---
 
CREATE TABLE grupo_usuarios (
  id INT IDENTITY(1,1) NOT NULL,
  descricao VARCHAR NULL DEFAULT NULL,
  cor_grupo VARCHAR NULL DEFAULT NULL,
  id_usuario_lider INT NULL DEFAULT NULL,
  ativo bit NULL DEFAULT NULL,
  PRIMARY KEY (id)
) --COMMENT 'Admin, Desenvolvedor, Tester';
 
-- ---
-- Table 'permissao'
-- Permissão que será validada em tela
-- ---
 
CREATE TABLE permissao (
  id INT IDENTITY(1,1) NOT NULL,
  descricao VARCHAR NULL DEFAULT NULL,
  PRIMARY KEY (id)
) --COMMENT 'Permissão que será validada em tela';
 
-- ---
-- Table 'grupo_usuario_x_permissao'
-- 
-- ---
 
CREATE TABLE grupo_usuario_x_permissao (
  id INT IDENTITY(1,1) NOT NULL,
  id_permissao INT NULL DEFAULT NULL,
  id_grupo_usuario INT NULL DEFAULT NULL,
  PRIMARY KEY (id)
);
 
-- ---
-- Table 'projeto_x_usuario'
-- 
-- ---
 
CREATE TABLE projeto_x_usuario (
  id INT IDENTITY(1,1) NOT NULL,
  id_projeto INT NULL DEFAULT NULL,
  id_usuario INT NULL DEFAULT NULL,
  PRIMARY KEY (id)
);
 
-- ---
-- Table 'avatar'
-- 
-- ---
 
CREATE TABLE avatar (
  id INT IDENTITY(1,1) NOT NULL,
  path_avatar VARCHAR NULL DEFAULT NULL,
  PRIMARY KEY (id)
);
 
-- ---
-- Table 'tarefa_x_comentario'
-- 
-- ---
 
CREATE TABLE tarefa_x_comentario (
  id INT IDENTITY(1,1) NOT NULL,
  id_tarefas INT NULL DEFAULT NULL,
  id_comentario INT NULL DEFAULT NULL,
  dt_comentário DATETIME NULL DEFAULT NULL,
  descricao VARCHAR NULL DEFAULT NULL,
  anexo VARCHAR NULL DEFAULT NULL,
  PRIMARY KEY (id)
);
 
-- ---
-- Table 'tarefa_x_usuario'
-- 
-- ---
 
CREATE TABLE tarefa_x_usuario (
  id INT IDENTITY(1,1) NOT NULL,
  id_usuario INT NULL DEFAULT NULL,
  id_tarefas INT NULL DEFAULT NULL,
  ativo bit NULL DEFAULT NULL,
  id_usuario_proximo INT NULL DEFAULT NULL, --COMMENT 'Próximo usuário que irá trabalhar na tarefa',
  dt_criacao DATETIME NULL DEFAULT NULL,
  id_grupo_usuarios_proximo INT NULL DEFAULT NULL,
  indice INT NULL DEFAULT NULL, -- COMMENT 'Conterá um indice para saber qual será o próximo usuário/gru',
  dt_inicio_tarefa DATETIME NULL DEFAULT NULL,
  dt_fim_tarefa DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (id)
);
 
-- ---
-- Table 'usuario_x_grupos_usuario'
-- 
-- ---
 
CREATE TABLE usuario_x_grupos_usuario (
  id INT IDENTITY(1,1) NOT NULL,
  id_grupos_usuario INT NULL DEFAULT NULL,
  id_usuario INT NULL DEFAULT NULL,
  PRIMARY KEY (id)
);
 
-- ---
-- Table 'status'
-- pause, block, play
-- ---
 
CREATE TABLE status (
  id INT IDENTITY(1,1) NOT NULL,
  descricao VARCHAR NULL DEFAULT NULL,
  PRIMARY KEY (id)
) --COMMENT 'pause, block, play';
 
-- ---
-- Table 'tipo'
-- normal, bug, novo requisito, etapa, sub-etapa, melhoria
-- ---
 
CREATE TABLE tipo (
  id INT IDENTITY(1,1) NOT NULL,
  descricao VARCHAR NULL DEFAULT NULL,
  inicial bit NULL DEFAULT NULL,
  final bit NULL DEFAULT NULL,
  PRIMARY KEY (id)
) --COMMENT 'normal, bug, novo requisito, etapa, sub-etapa, melhoria';
 
-- ---
-- Table 'classificacao'
-- DB, UI, Planejamento, Reunião
-- ---
 
CREATE TABLE classificacao (
  id INT IDENTITY(1,1) NOT NULL,
  descricao VARCHAR NULL DEFAULT NULL,
  ativo bit NULL DEFAULT NULL,
  PRIMARY KEY (id)
) --COMMENT 'DB, UI, Planejamento, Reunião';
 
-- ---
-- Table 'grupo_usuarios_x_fases'
-- 
-- ---
 
CREATE TABLE grupo_usuarios_x_fases (
  id INT IDENTITY(1,1) NOT NULL,
  id_grupo_usuarios INT NULL DEFAULT NULL,
  id_fases INT NULL DEFAULT NULL,
  PRIMARY KEY (id)
);
 
-- ---
-- Foreign Keys 
-- ---
 
ALTER TABLE sprints ADD FOREIGN KEY (id_sprints_dependencia) REFERENCES sprints (id);
ALTER TABLE tarefas ADD FOREIGN KEY (id_sprints) REFERENCES sprints (id);
ALTER TABLE tarefas ADD FOREIGN KEY (id_projeto) REFERENCES projeto (id);
ALTER TABLE tarefas ADD FOREIGN KEY (id_status) REFERENCES status (id);
ALTER TABLE tarefas ADD FOREIGN KEY (id_grupo_usuarios_x_fases) REFERENCES grupo_usuarios_x_fases (id);
ALTER TABLE tarefas ADD FOREIGN KEY (id_usuario_creator) REFERENCES usuario (id);
ALTER TABLE tarefas ADD FOREIGN KEY (id_tipo) REFERENCES tipo (id);
ALTER TABLE tarefas ADD FOREIGN KEY (id_classificacao) REFERENCES classificacao (id);
ALTER TABLE tarefas ADD FOREIGN KEY (id_tarefa_dependencia) REFERENCES tarefas (id);
ALTER TABLE tarefas ADD FOREIGN KEY (id_tarefa_agrupador) REFERENCES tarefas (id);
ALTER TABLE usuario ADD FOREIGN KEY (id_avatar) REFERENCES avatar (id);
ALTER TABLE grupo_usuarios ADD FOREIGN KEY (id_usuario_lider) REFERENCES usuario (id);
ALTER TABLE grupo_usuario_x_permissao ADD FOREIGN KEY (id_permissao) REFERENCES permissao (id);
ALTER TABLE grupo_usuario_x_permissao ADD FOREIGN KEY (id_grupo_usuario) REFERENCES grupo_usuarios (id);
ALTER TABLE projeto_x_usuario ADD FOREIGN KEY (id_projeto) REFERENCES projeto (id);
ALTER TABLE projeto_x_usuario ADD FOREIGN KEY (id_usuario) REFERENCES usuario (id);
ALTER TABLE tarefa_x_comentario ADD FOREIGN KEY (id_tarefas) REFERENCES tarefas (id);
ALTER TABLE tarefa_x_usuario ADD FOREIGN KEY (id_usuario) REFERENCES usuario (id);
ALTER TABLE tarefa_x_usuario ADD FOREIGN KEY (id_tarefas) REFERENCES tarefas (id);
ALTER TABLE tarefa_x_usuario ADD FOREIGN KEY (id_usuario_proximo) REFERENCES usuario (id);
ALTER TABLE tarefa_x_usuario ADD FOREIGN KEY (id_grupo_usuarios_proximo) REFERENCES grupo_usuarios (id);
ALTER TABLE usuario_x_grupos_usuario ADD FOREIGN KEY (id_grupos_usuario) REFERENCES grupo_usuarios (id);
ALTER TABLE usuario_x_grupos_usuario ADD FOREIGN KEY (id_usuario) REFERENCES usuario (id);
ALTER TABLE grupo_usuarios_x_fases ADD FOREIGN KEY (id_grupo_usuarios) REFERENCES grupo_usuarios (id);
ALTER TABLE grupo_usuarios_x_fases ADD FOREIGN KEY (id_fases) REFERENCES fases (id);
 
-- ---
-- Table Properties
-- ---
 
-- ALTER TABLE 'projeto' ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE 'sprints' ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE 'tarefas' ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE 'fases' ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE 'usuario' ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE 'grupo_usuarios' ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE 'permissao' ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE 'grupo_usuario_x_permissao' ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE 'projeto_x_usuario' ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE 'avatar' ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE 'tarefa_x_comentario' ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE 'tarefa_x_usuario' ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE 'usuario_x_grupos_usuario' ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE 'status' ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE 'tipo' ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE 'classificacao' ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE 'grupo_usuarios_x_fases' ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
 
-- ---
-- Test Data
-- ---
 
-- INSERT INTO 'projeto' ('id','descricao') VALUES
-- ('','');
-- INSERT INTO 'sprints' ('id','id_sprints_dependencia','descricao','dt_inicio','dt_fim') VALUES
-- ('','','','','');
-- INSERT INTO 'tarefas' ('id','id_sprints','id_projeto','descricao','id_status','id_grupo_usuarios_x_fases','indice','id_usuario_creator','tempo_estimado','tempo_trabalhado','id_tipo','id_classificacao','tarefa_planejada','id_tarefa_dependencia','dt_criacao','id_tarefa_agrupador') VALUES
-- ('','','','','','','','','','','','','','','','');
-- INSERT INTO 'fases' ('id','descricao','ativo') VALUES
-- ('','','');
-- INSERT INTO 'usuario' ('id','id_avatar','descricao','nome_usuario','login','senha') VALUES
-- ('','','','','','');
-- INSERT INTO 'grupo_usuarios' ('id','descricao','cor_grupo','id_usuario_lider','ativo') VALUES
-- ('','','','','');
-- INSERT INTO 'permissao' ('id','descricao') VALUES
-- ('','');
-- INSERT INTO 'grupo_usuario_x_permissao' ('id','id_permissao','id_grupo_usuario') VALUES
-- ('','','');
-- INSERT INTO 'projeto_x_usuario' ('id','id_projeto','id_usuario') VALUES
-- ('','','');
-- INSERT INTO 'avatar' ('id','path_avatar') VALUES
-- ('','');
-- INSERT INTO 'tarefa_x_comentario' ('id','id_tarefas','id_comentario','dt_comentário','descricao','anexo') VALUES
-- ('','','','','','');
-- INSERT INTO 'tarefa_x_usuario' ('id','id_usuario','id_tarefas','ativo','id_usuario_proximo','dt_criacao','id_grupo_usuarios_proximo','indice','dt_inicio_tarefa','dt_fim_tarefa') VALUES
-- ('','','','','','','','','','');
-- INSERT INTO 'usuario_x_grupos_usuario' ('id','id_grupos_usuario','id_usuario') VALUES
-- ('','','');
-- INSERT INTO 'status' ('id','descricao') VALUES
-- ('','');
-- INSERT INTO 'tipo' ('id','descricao','inicial','final') VALUES
-- ('','','','');
-- INSERT INTO 'classificacao' ('id','descricao','ativo') VALUES
-- ('','','');
-- INSERT INTO 'grupo_usuarios_x_fases' ('id','id_grupo_usuarios','id_fases') VALUES
-- ('','','');