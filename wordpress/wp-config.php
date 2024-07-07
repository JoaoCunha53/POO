<?php
/**
 * A configuração de base do WordPress
 *
 * O script de criação wp-config.php utiliza este ficheiro durante a instalação.
 * Não é necessário utilizar o site, pode copiar este ficheiro para "wp-config.php"
 * e preencher os valores.
 *
 * Este ficheiro contém as seguintes configurações:
 *
 * * Configurações de MySQL
 * * Chaves secretas
 * * Prefixo das tabelas da base de dados
 * * ABSPATH
 *
 * @link https://wordpress.org/support/article/editing-wp-config-php/
 *
 * @package WordPress
 */

// ** Definições da base de dados - obtenha estes dados do seu serviço de alojamento ** //

/**
 *
 * O nome da base de dados do WordPress
 */
define( 'DB_NAME', 'wordpress' );

/**
 *
 * O nome do utilizador da base de dados
 */
define( 'DB_USER', 'root' );

/**
 *
 * A senha do utilizador da base de dados
 */
define( 'DB_PASSWORD', '' );

/**
 *
 * O nome do servidor da base de dados
 */
define( 'DB_HOST', 'localhost' );

/**
 *
 * O "Database Charset" a usar na criação das tabelas.
 */
define( 'DB_CHARSET', 'utf8mb4' );

/**
 *
 * O "Database Collate type". Se tem dúvidas não mude.
 */
define( 'DB_COLLATE', '' );

/**
 *
 * #@+
 * Chaves únicas de autenticação.
 *
 * Mude para frases únicas e diferentes!
 * Pode gerar frases automaticamente em {@link https://api.wordpress.org/secret-key/1.1/salt/ Serviço de chaves secretas de WordPress.org}
 *
 * Pode mudar estes valores em qualquer momento para invalidar todos os cookies existentes.
 * Isto forçará todos os utilizadores a terem de iniciar sessão novamente.
 *
 * @since 2.6.0
 */
define( 'AUTH_KEY', 'c7h;`%Ny0ct<7Y)nl}>+<NnUVC6C`;ETFK! T$<wHj|2$p)&9<0#s;3Tf~7GS4m.' );
define( 'SECURE_AUTH_KEY', 'ru`NDq]kD@CxS*y}lVpVz56!XrnJX7v$F.U:s_^6Xzru%I{U(i&[z1&b>/~g3:wj' );
define( 'LOGGED_IN_KEY', ')u;/TWVehu>NQJa6n[f/Sh~0oJ!Z<rVD+ftvdaB]Qw;bUjx1Y<]B!?j@*wq)D3xr' );
define( 'NONCE_KEY', '<C9Xk?f:W(%;Bz^qE(_#e^Lxt~B])p!_{d?rfqTtoky87W]0 6h([poueW!7!yOQ' );
define( 'AUTH_SALT', 'C&d3lqZMKRiwi7yoJ.C$fxQ`91DV2.9e*6-Hp-K0)cwpU=IUDMQ^}5RuCUw/o5_ ' );
define( 'SECURE_AUTH_SALT', 'XjDSr<33LBvFv9nR/u&R48bmK?qbcj[vORURZ3q<:aofL[ctE2m7TQbe8NnVsVO+' );
define( 'LOGGED_IN_SALT', '/_7TG$9lWq_KhQ,W~44v|;o7 nhVC5@hG&%r]3$^7zD$|hC=k%ne%JNe-{r4:dD]' );
define( 'NONCE_SALT', 'nM5D?)2|rEz{dvjl5D)a6fy)pZprUBiNLm6?dOHhfH<%!H9i;24tb;s5iUzZ&@YA' );

/**
 *
 * #@-
 */

/**
 * Prefixo das tabelas do WordPress.
 *
 * Pode suportar múltiplas instalações numa só base de dados, ao dar a cada
 * instalação um prefixo único. Só algarismos, letras e underscores, por favor!
 */
$table_prefix = 'wp_';

/**
 * Para programadores: WordPress em modo de depuração.
 *
 * Mude isto para true para mostrar avisos enquanto estiver a testar.
 * É vivamente recomendado aos autores de temas e plugins usarem WP_DEBUG
 * no seu ambiente de desenvolvimento.
 *
 * Para mais informações sobre outras constantes que pode usar para depuração,
 * consulte a documentação.
 *
 * @link https://developer.wordpress.org/advanced-administration/debug/debug-wordpress/
 */
define( 'WP_DEBUG', false );

/* Adicione quaisquer valores personalizados entre esta linha e a linha "pare de editar". */



/* E é tudo, pare de editar! */

/**
 *
 * Caminho absoluto para o directório do WordPress.
 */
if ( ! defined( 'ABSPATH' ) ) {
	define( 'ABSPATH', __DIR__ . '/' );
}

/**
 *
 * Define as variáveis do WordPress e ficheiros a incluir.
 */
require_once ABSPATH . 'wp-settings.php';
